using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Db.Model;

namespace WinAppDemo.Forms
{
    public partial class FormGjglNewAj : Form
    {
        public Case Case { get; set; } = new Case();

        public FormGjglNewAj()
        {
            InitializeComponent();

            textBox2.Text = Guid.NewGuid().ToString();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Program.m_mainform.AddNewGjalZj();

            this.Case.CaseName = textBox1.Text;
            this.Case.CaseSerialNum = textBox2.Text;
            this.Case.CaseType = comboBox1.Text;
            this.Case.Collecter = textBox3.Text;
            this.Case.CollecterNum = textBox4.Text;
            this.Case.CollecterDepartMent = comboBox2.Text;
            this.Case.InspectionPersonName = textBox5.Text;
            this.Case.InspectionPersonDepartMent = textBox6.Text;
            this.Case.OrganizationCode = textBox7.Text;
            this.Case.Note = textBox8.Text;

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("取消");
        }
    }
}
