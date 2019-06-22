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

namespace WinAppDemo.Controls
{
    public partial class UcZjtq_SJ_QZ2 : UserControl
    {
        public UcZjtq_SJ_QZ2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Clear();

            AppContext.GetInstance().m_ucZjtq_sj_qz1.Dock = DockStyle.Fill;
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Clear();
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Add(AppContext.GetInstance().m_ucZjtq_sj_qz1);
        }

        private void UcZjtq_SJ_QZ2_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 30;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            IList<string> imglist = new List<string>();

            string exePath = System.Windows.Forms.Application.StartupPath;

            imglist.Add(exePath + "/Images/test1.jpg");
            imglist.Add(exePath + "/Images/test2.png");
            imglist.Add(exePath + "/Images/test3.jpg");

            FormGjglZzqx form = new FormGjglZzqx(imglist);
            form.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            label2.Text = "获取完成";
            FormGjglZzqk form = new FormGjglZzqk();
            form.ShowDialog();
        }
    }
}
