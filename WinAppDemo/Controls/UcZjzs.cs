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
                        panel2.Show();
                        panel2.Dock = DockStyle.Fill;

                        listBox1.Items.Clear();
                        using (SqliteDbContext context = new SqliteDbContext())
                        {
                            listBox1.Items.AddRange(context.WxFriends
                                .ToArray()
                                .Where(friend => friend.Type == type)
                                .Select(friend => $"{friend.NickName.PadRight(30)}\t\t({friend.WxId})")
                                .ToArray());
                        }

                        break;
                    }
                default:
                    {
                        panel2.Hide();
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
    }

    public class TreeNodeTypes
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public int ParentId { get; set; }
    }
}
