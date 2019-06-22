using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Forms;

using WinAppDemo.Db.Base;
using WinAppDemo.Db.Model;

namespace WinAppDemo.Controls
{
    public partial class UcAjgl : UserControl
    {
        public UcAjgl()
        {
            InitializeComponent();
        }

        private void UcAjgl_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //新建案件
            FormGjglNewAj form = new FormGjglNewAj();
            form.ShowDialog();
        }

        private void UcAjgl_Load(object sender, EventArgs e)
        {
            using (SqliteDbContext db = new SqliteDbContext())
            {

                var userlist = db.WxAccounts.ToList();

                dataGridView1.DataSource = userlist;

                //User people = new User()
                //{
                //    station_id = "Hello",
                //    device_id = "Hello",
                //    position = "Hello",
                //    status = 1,
                //    last_time = "World"
                //};
                //db.Users.Add(people);
                //db.SaveChanges();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.label5.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string wxid = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.label7.Text = wxid;

                if (!String.IsNullOrWhiteSpace(wxid))
                {
                    using (SqliteDbContext db = new SqliteDbContext())
                    {
                        var userlist = db.WxMessages.Where(a => a.WxId == wxid).ToList();

                        dataGridView2.DataSource = userlist;
                    }
                }
            }
        }
    }
}
