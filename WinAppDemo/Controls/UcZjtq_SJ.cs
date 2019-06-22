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
    public partial class UcZjtq_SJ : UserControl
    {
        public UcZjtq_SJ()
        {
            InitializeComponent();

        }

        private void UcZjtq_SJ_Load(object sender, EventArgs e)
        {
            init();
        }

        public void init()
        {
            UcZjtq_SJ_Lj lj = new UcZjtq_SJ_Lj();
            lj.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(lj);
        }

    }
}
