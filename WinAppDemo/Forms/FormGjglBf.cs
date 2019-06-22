using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Controls;

namespace WinAppDemo.Forms
{
    public partial class FormGjglBf : Form
    {

        public FormGjglBf()
        {
            InitializeComponent();
        }

        private void FormGjglBf_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            IList<string> imglist = new List<string>();

            string exePath = System.Windows.Forms.Application.StartupPath;

            imglist.Add(exePath + "/Images/test1.jpg");
            imglist.Add(exePath + "/Images/test2.png");
            imglist.Add(exePath + "/Images/test3.jpg");

            UcZjtq_SJ_QZ5 m_ucZjtq_sj_qz5 = new UcZjtq_SJ_QZ5(imglist);


            AppContext.GetInstance().m_ucZjtq_sj.Controls.Clear();

            m_ucZjtq_sj_qz5.Dock = DockStyle.Fill;
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Clear();
            AppContext.GetInstance().m_ucZjtq_sj.Controls.Add(m_ucZjtq_sj_qz5);

            this.Close();
        }

    }
}
