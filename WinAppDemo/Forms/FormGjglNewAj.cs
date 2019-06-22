using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDemo.Forms
{
    public partial class FormGjglNewAj : Form
    {
        public FormGjglNewAj()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Program.m_mainform.AddNewGjalZj();
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("取消");
        }
    }
}
