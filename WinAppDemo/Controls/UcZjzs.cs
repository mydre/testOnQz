using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Db.Base;
using WinAppDemo.Db.Model;

namespace WinAppDemo.Controls
{
    public partial class UcZjzs : UserControl
    {
        private List<TreeNodeTypes> Types;
        public UcZjzs()
        {
            InitializeComponent();
        }

        private void UcZjzs_Load(object sender, EventArgs e)
        {
            Types = new List<TreeNodeTypes>()
            {
                new TreeNodeTypes() {Id = 1, Name = @"努比亚降级（47\13433\13480）", Value = "1", ParentId = 0},
                new TreeNodeTypes() {Id = 2, Name = @"手机信息（47\13433\13480）", Value = "2", ParentId = 1},
                new TreeNodeTypes() {Id = 3, Name = @"即时通讯（47\13433\13480）", Value = "3", ParentId = 1},
                new TreeNodeTypes() {Id = 4, Name = @"基本信息（47\13433\13480）", Value = "4", ParentId = 2},
                new TreeNodeTypes() {Id = 5, Name = @"通讯录（47\13433\13480）", Value = "5", ParentId = 2},
                new TreeNodeTypes() {Id = 6, Name = @"微信（47\13433\13480）", Value = "6", ParentId = 3},
            };

            using (SqliteDbContext context = new SqliteDbContext())
            {
                context.WxAccounts.ToList().ForEach(acc =>
                {
                    int index = Types.Count + 1;
                    Types.Add(new TreeNodeTypes() { Id = index, Name = acc.Sign, ParentId = 6, Value = acc.WxId });
                    Types.Add(new TreeNodeTypes() { Id = index + 1, Name = "好友", ParentId = index, Value = "好友" });
                    Types.Add(new TreeNodeTypes() { Id = index + 2, Name = "公众号", ParentId = index, Value = "公众号" });
                    Types.Add(new TreeNodeTypes() { Id = index + 3, Name = "聊天记录", ParentId = index, Value = "聊天记录" });
                });
            }


            var topNode = new TreeNode();
            topNode.Name = "0";
            topNode.Text = @"努比亚备份（已删除\未删除\总共）";
            treeView1.Nodes.Add(topNode);
            Bind(topNode, Types, 0);

            treeView1.ExpandAll();
        }

        private void Bind(TreeNode parNode, List<TreeNodeTypes> list, int nodeId)
        {
            var childList = list.FindAll(t => t.ParentId == nodeId).OrderBy(t => t.Id);

            foreach (var urlTypese in childList)
            {
                var node = new TreeNode();
                node.Name = urlTypese.Id.ToString();
                node.Text = urlTypese.Name;
                node.Tag = urlTypese.Value;
                parNode.Nodes.Add(node);
                Bind(node, list, urlTypese.Id);
            }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string wxid = e.Node.Tag as string;
            string id = e.Node.Name;

            switch (wxid)
            {
                case "好友":
                case "公众号":
                    {
                        int type = wxid == "好友" ? 3 : 33;

                        panel1.Hide();
                        panel3.Hide();
                        panel2.Show();
                        panel2.Dock = DockStyle.Fill;

                        this.dataGridView1.DataSource = null;
                        using (SqliteDbContext context = new SqliteDbContext())
                        {
                            this.dataGridView1.DataSource = context.WxFriends
                                .Where(friend => friend.Type == type)
                                .ToList();
                        }

                        break;
                    }
                case "聊天记录":
                    {
                        panel1.Hide();
                        panel2.Hide();
                        panel3.Show();
                        panel3.Dock = DockStyle.Fill;

                        this.dataGridView2.Rows.Clear();
                        using (SqliteDbContext context = new SqliteDbContext())
                        {
                            this.dataGridView2.Rows.AddRange(
                                context.WxFriends
                                .Where(friend => friend.Type == 3)
                                .Select(new Func<WxFriend, DataGridViewRow>((f) =>
                                {
                                    var row = new DataGridViewRow();
                                    row.CreateCells(this.dataGridView2, new[] {null, f.NickName, context.WxMessages.Count(m => m.WxId == f.WxId).ToString() });
                                    return row;
                                }))
                                .ToArray());
                        }

                        break;
                    }
                default:
                    {
                        panel2.Hide();
                        panel3.Hide();
                        panel1.Show();
                        panel1.Dock = DockStyle.Fill;
                        WxAccount acc = null;
                        using (SqliteDbContext context = new SqliteDbContext())
                        {
                            acc = context.WxAccounts.FirstOrDefault(a => a.WxId == wxid);

                        }

                        if (acc == null)
                        {
                            if (Types != null && Types.Count > 0)
                            {
                                foreach (TreeNodeTypes tnt in Types)
                                {
                                    if (Convert.ToString(tnt.Id) == id)
                                    {
                                        lblCode.Text = tnt.Value;
                                        lblName.Text = tnt.Name;
                                        label8.Text = string.Empty;
                                        label9.Text = string.Empty;
                                        label10.Text = string.Empty;
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            lblCode.Text = acc.WxId;
                            lblName.Text = acc.Sign;
                            label8.Text = acc.Phone;
                            label9.Text = acc.NickName;
                            label10.Text = acc.District;
                        }

                        break;
                    }
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCheckBoxCell dgcc = (DataGridViewCheckBoxCell)this.dataGridView2.Rows[e.RowIndex].Cells[0];
            Boolean flag = Convert.ToBoolean(dgcc.Value);
            dgcc.Value = flag == true ? false : true;
          




            if (e.RowIndex < 0)
            {
                return;
            }

            using (SqliteDbContext context = new SqliteDbContext())
            {
                richTextBox1.Clear();
                string nickName = this.dataGridView2.Rows[e.RowIndex].Cells[0].Value as string;
                WxFriend friend = context.WxFriends.FirstOrDefault(f => f.NickName == nickName);//仅查找一条数据
                if (friend == null)//如果没有找到
                {
                    return;
                }

                var messages = context.WxMessages //
                    .Where(m => m.WxId == friend.WxId)
                    .OrderBy(m => m.CraeteTime)
                    .ToList();

                messages.ForEach(m =>
                {
                    if (m.IsSend == 1)
                    {
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                        richTextBox1.SelectionColor = Color.DimGray;
                        richTextBox1.AppendText($"{m.CraeteTime}\n");
                        richTextBox1.SelectionColor = Color.Red;
                    }
                    else
                    {
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                        richTextBox1.SelectionColor = Color.DimGray;
                        richTextBox1.AppendText($"{m.CraeteTime}\n");
                        richTextBox1.SelectionColor = Color.Blue;
                    }

                    richTextBox1.SelectionBackColor = Color.WhiteSmoke;
                    richTextBox1.AppendText($"{m.Content}\n\n");
                });
            }
            


        }
    }

    public class TreeNodeTypes
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int ParentId { get; set; }
    }
}
