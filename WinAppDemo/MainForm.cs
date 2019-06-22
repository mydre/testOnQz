using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Controls;
using WinAppDemo.Db.Base;
using WinAppDemo.Db.Model;

namespace WinAppDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "手机数据取证系统LX-A200-努比亚备份";

            TitleButtionInit();
            btnAjgl.BackgroundImage = Properties.Resources.ajgl1;
            DisplayContent(new UcAjgl());

            int i = 0;
            i++;
        }

        private void DisplayContent(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.WinContent.Controls.Clear();
            this.WinContent.Controls.Add(uc);
        }

        private void TitleButtionInit()
        {
            btnAjgl.BackgroundImage = Properties.Resources.ajgl;
            btnZjtq.BackgroundImage = Properties.Resources.zjtq;
            btnZjzs.BackgroundImage = Properties.Resources.zjzs;
            btnTools.BackgroundImage = Properties.Resources.gj;
        }

        private void BtnAjgl_Click(object sender, EventArgs e)
        {
            TitleButtionInit();
            btnAjgl.BackgroundImage = Properties.Resources.ajgl1;
            DisplayContent(new UcAjgl());
        }

        private void BtnZjtq_Click(object sender, EventArgs e)
        {
            AddNewGjalZj();
        }

        private void BtnZjzs_Click(object sender, EventArgs e)
        {
            AddNewGjalZs();
        }

        private void BtnTools_Click(object sender, EventArgs e)
        {
            TitleButtionInit();
            btnTools.BackgroundImage = Properties.Resources.gj1;
            DisplayContent(new UcTools());
        }

        public void AddNewGjalZj()
        {
            TitleButtionInit();
            btnZjtq.BackgroundImage = Properties.Resources.zjtq1;
            DisplayContent(new UcZjtq());
        }

        public void AddNewGjalZs()
        {
            TitleButtionInit();
            btnZjzs.BackgroundImage = Properties.Resources.zjzs1;
            DisplayContent(new UcZjzs());
        }
    }
}
