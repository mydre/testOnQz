using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Db.Base;
using WinAppDemo.Db.Model;

namespace WinAppDemo.Forms
{
    public partial class FormGjglZzxx : Form
    {
        public FormGjglZzxx()
        {
            InitializeComponent();

            textBox2.Text = Guid.NewGuid().ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Program.m_mainform.AddNewGjalZs();

            using (var context = new CaseContext())
            {
                Case @case = context.Cases.Find(39);
                Proof proof = new Proof()
                {
                    Case = @case,
                    ProofName = textBox1.Text,
                    ProofSerialNum = textBox2.Text,
                    PhoneNum = textBox6.Text,
                    phoneNum2 = textBox3.Text,
                    Holder = textBox4.Text,
                    ProofType = comboBox2.Text,
                    note = textBox8.Text,
                };
                @case.Proofs.Add(proof);

                context.SaveChanges();
            }

            this.Close();
            AppContext.setInstanceNull();
        }
    }
}
