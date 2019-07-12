﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppDemo.Forms;
using WinAppDemo.Db.Base;
using WinAppDemo.Db.Model;
using System.Threading;

namespace WinAppDemo.Controls
{
    public partial class UcAjgl : UserControl
    {
        public UcAjgl()
        {
            InitializeComponent();
        }

        private void UcAjgl_SizeChanged(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //新建案件
            FormGjglNewAj form = new FormGjglNewAj();
            string s = form.ShowDialog().ToString();
            if(s == "Cancel") return;

            Case @case = form.Case;
            using (var context = new CaseContext())
            {
                context.Cases.Add(@case);
                context.SaveChanges();
                AppContext.CaseID = @case.CaseId;
            }

            Program.m_mainform.AddNewGjalAj();
        }

        private void UcAjgl_Load(object sender, EventArgs e)
        {
            using (var context = new CaseContext())
            {
                var cases = context.Cases.AsNoTracking().ToList();
                this.dataGridView1.DataSource = cases;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AppConfig.getAppConfig().caseId_selected_row = (int)this.dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                DataGridViewCheckBoxCell dgcc = (DataGridViewCheckBoxCell)this.dataGridView1.Rows[e.RowIndex].Cells[0];
                Boolean flag = Convert.ToBoolean(dgcc.Value);
                dgcc.Value = flag == true ? false : true;
            }
            catch (Exception)
            {
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var row = this.dataGridView1.SelectedRows[0];
            int caseId = (int)row.Cells[1].Value;
            this.label5.Text = caseId.ToString();
            this.label7.Text = row.Cells[1]?.Value?.ToString() ?? string.Empty;

            using (var context = new CaseContext())
            {
                var proofs = context.Proofs.AsNoTracking().Where(p => p.CaseID == caseId).ToList();
                dataGridView2.DataSource = proofs;
            }

        }



        private void clickAddEvidence(object sender, EventArgs e)
        {
            AppConfig ac = AppConfig.getAppConfig();

            if(ac.caseId_selected_row == -1)
            {
                MessageBox.Show("请选择案件","提示");
                return;
            }else if (ac.already_working == false)
            {
                DialogResult dr = MessageBox.Show("是否要为编号为" + ac.caseId_selected_row + "的案件添加证据", "提示", MessageBoxButtons.OKCancel);

                if (dr == DialogResult.OK)
                {
                    ac.caseId_selected_working = ac.caseId_selected_row;
                    ac.already_working = true;
                }
                else if (dr == DialogResult.Cancel)
                {
                    ac.caseId_selected_row = -1;
                    return;
                }

            }else
            {
                if(ac.caseId_selected_row != ac.caseId_selected_working)
                {
                    DialogResult dr = MessageBox.Show("你之前对编号为" + ac.caseId_selected_working + "的案件添加证据(未保存)，是否确定要为编号为" +ac.caseId_selected_row +  "的案件添加证据！", "提示", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        ac.caseId_selected_working = ac.caseId_selected_row;
                        AppContext.setInstanceNull();
                    }
                    else if (dr == DialogResult.Cancel)
                    {
                        ac.caseId_selected_row = -1;
                        return;
                    }
                }
            }
            ac.caseId_selected_row = -1;

            Program.m_mainform.AddNewGjalZj();

            //UcZjtq uc = new UcZjtq();
            //uc.Dock = DockStyle.Fill;
            //var p = this.Parent.Parent.Controls["WinContent"].Controls;
            //this.Parent.Parent.Controls["WinContent"].Controls.Clear();
            //p.Add(uc);


        }

        private void allCheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            bool allCheck = false;
            if(c.Checked == true)
            {
                allCheck = true;
            }
            foreach (DataGridViewRow dgvr in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell dgcc = (DataGridViewCheckBoxCell)dgvr.Cells[0];
                Boolean flag = Convert.ToBoolean(allCheck);
                dgcc.Value = flag;
            }
        }

        private void DataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewCheckBoxCell dgcc = (DataGridViewCheckBoxCell)this.dataGridView2.Rows[e.RowIndex].Cells[0];
                Boolean flag = Convert.ToBoolean(dgcc.Value);
                dgcc.Value = flag == true ? false : true;
            }
            catch (Exception)
            {
            }
        }
    }
}
