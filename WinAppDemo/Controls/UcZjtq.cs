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
    public partial class UcZjtq : UserControl
    {
        public UcZjtq()
        {
            InitializeComponent();
        }

        private void UcZjtq_Load(object sender, EventArgs e)
        {
            InitBtn();
            btnShouJi.BackgroundImage = Properties.Resources.item12;
            DisplayContent(AppContext.GetInstance().m_ucZjtq_sj);
        }

        private void InitBtn()
        {
            btnShouJi.BackgroundImage = Properties.Resources.item11;
            btnJingXiang.BackgroundImage = Properties.Resources.item21;
        }

        private void DisplayContent(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(uc);
        }

        private void BtnShouJi_Click(object sender, EventArgs e)
        {
            InitBtn();
            btnShouJi.BackgroundImage = Properties.Resources.item12;
            DisplayContent(AppContext.GetInstance().m_ucZjtq_sj);
        }

        private void BtnJingXiang_Click(object sender, EventArgs e)
        {
            InitBtn();
            btnJingXiang.BackgroundImage = Properties.Resources.item22;
            DisplayContent(AppContext.GetInstance().m_ucZjtq_jx);
        }
    }
}
