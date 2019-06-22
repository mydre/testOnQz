namespace WinAppDemo.Controls
{
    partial class UcZjtq
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJingXiang = new System.Windows.Forms.Panel();
            this.btnShouJi = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnJingXiang);
            this.panel1.Controls.Add(this.btnShouJi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 668);
            this.panel1.TabIndex = 0;
            // 
            // btnJingXiang
            // 
            this.btnJingXiang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJingXiang.Location = new System.Drawing.Point(0, 42);
            this.btnJingXiang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1111111111);
            this.btnJingXiang.Name = "btnJingXiang";
            this.btnJingXiang.Size = new System.Drawing.Size(184, 42);
            this.btnJingXiang.TabIndex = 1;
            this.btnJingXiang.Click += new System.EventHandler(this.BtnJingXiang_Click);
            // 
            // btnShouJi
            // 
            this.btnShouJi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShouJi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShouJi.Location = new System.Drawing.Point(0, 0);
            this.btnShouJi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1111111111);
            this.btnShouJi.Name = "btnShouJi";
            this.btnShouJi.Size = new System.Drawing.Size(184, 42);
            this.btnShouJi.TabIndex = 0;
            this.btnShouJi.Click += new System.EventHandler(this.BtnShouJi_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 668);
            this.panel2.TabIndex = 1;
            // 
            // UcZjtq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UcZjtq";
            this.Size = new System.Drawing.Size(1000, 668);
            this.Load += new System.EventHandler(this.UcZjtq_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel btnJingXiang;
        private System.Windows.Forms.Panel btnShouJi;
    }
}
