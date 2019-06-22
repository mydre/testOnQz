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
    public partial class UcZjtq_SJ_QZ6 : UserControl
    {
        public UcZjtq_SJ_QZ6()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FormGjglZzqkWc from = new FormGjglZzqkWc();
            from.ShowDialog();
        }
    }
}
