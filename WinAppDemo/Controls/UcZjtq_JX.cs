using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppDemo.Controls
{
    public partial class UcZjtq_JX : UserControl
    {
        public UcZjtq_JX()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = "所有文件|*.*";
            fileDialog.RestoreDirectory = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
                textBox1.Text = System.IO.Path.GetFullPath(fileDialog.FileName);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = "所有文件|*.*";
            fileDialog.RestoreDirectory = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
                textBox2.Text = System.IO.Path.GetFullPath(fileDialog.FileName);
        }
    }
}
