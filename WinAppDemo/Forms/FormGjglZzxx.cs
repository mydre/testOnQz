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
    public partial class FormGjglZzxx : Form
    {
        public FormGjglZzxx()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Program.m_mainform.AddNewGjalZs();
            this.Close();
        }
    }
}
