namespace StudentSociety
{
    partial class MoneyCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.njfpeople = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.njfid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.njfbm = new System.Windows.Forms.TextBox();
            this.njfnr = new System.Windows.Forms.RichTextBox();
            this.njfmoney = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "不通过";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "通过";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.njfpeople);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.njfid);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.njfbm);
            this.groupBox5.Controls.Add(this.njfnr);
            this.groupBox5.Controls.Add(this.njfmoney);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(23, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 211);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "经费申请信息";
            // 
            // njfpeople
            // 
            this.njfpeople.Location = new System.Drawing.Point(360, 159);
            this.njfpeople.Name = "njfpeople";
            this.njfpeople.Size = new System.Drawing.Size(120, 21);
            this.njfpeople.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "申请人：";
            // 
            // njfid
            // 
            this.njfid.Location = new System.Drawing.Point(111, 159);
            this.njfid.Name = "njfid";
            this.njfid.Size = new System.Drawing.Size(120, 21);
            this.njfid.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "经费编号：";
            // 
            // njfbm
            // 
            this.njfbm.Location = new System.Drawing.Point(360, 30);
            this.njfbm.Name = "njfbm";
            this.njfbm.Size = new System.Drawing.Size(120, 21);
            this.njfbm.TabIndex = 17;
            // 
            // njfnr
            // 
            this.njfnr.Location = new System.Drawing.Point(106, 73);
            this.njfnr.Name = "njfnr";
            this.njfnr.Size = new System.Drawing.Size(374, 77);
            this.njfnr.TabIndex = 16;
            this.njfnr.Text = "";
            // 
            // njfmoney
            // 
            this.njfmoney.Location = new System.Drawing.Point(106, 30);
            this.njfmoney.Name = "njfmoney";
            this.njfmoney.Size = new System.Drawing.Size(120, 21);
            this.njfmoney.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(46, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "活动内容：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(295, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 1;
            this.label21.Text = "申请部门：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label22.Location = new System.Drawing.Point(46, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "申请金额：";
            // 
            // MoneyCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 327);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Name = "MoneyCheck";
            this.Text = "MoneyCheck";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox njfpeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox njfid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox njfbm;
        private System.Windows.Forms.RichTextBox njfnr;
        private System.Windows.Forms.TextBox njfmoney;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}