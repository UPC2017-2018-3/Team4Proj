namespace StudentSociety
{
    partial class ActivityCheck
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
            this.nacid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nacend = new System.Windows.Forms.TextBox();
            this.nacstart = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nacpeople = new System.Windows.Forms.TextBox();
            this.nacmoney = new System.Windows.Forms.TextBox();
            this.nacadd = new System.Windows.Forms.TextBox();
            this.nactext = new System.Windows.Forms.TextBox();
            this.nacname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nacid
            // 
            this.nacid.Location = new System.Drawing.Point(327, 168);
            this.nacid.Name = "nacid";
            this.nacid.Size = new System.Drawing.Size(100, 21);
            this.nacid.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(256, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "活动编号：";
            // 
            // nacend
            // 
            this.nacend.Location = new System.Drawing.Point(120, 168);
            this.nacend.Name = "nacend";
            this.nacend.Size = new System.Drawing.Size(100, 21);
            this.nacend.TabIndex = 49;
            // 
            // nacstart
            // 
            this.nacstart.Location = new System.Drawing.Point(120, 128);
            this.nacstart.Name = "nacstart";
            this.nacstart.Size = new System.Drawing.Size(100, 21);
            this.nacstart.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(424, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "不通过";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "通过";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nacpeople
            // 
            this.nacpeople.Location = new System.Drawing.Point(327, 128);
            this.nacpeople.Name = "nacpeople";
            this.nacpeople.Size = new System.Drawing.Size(100, 21);
            this.nacpeople.TabIndex = 45;
            // 
            // nacmoney
            // 
            this.nacmoney.Location = new System.Drawing.Point(327, 88);
            this.nacmoney.Name = "nacmoney";
            this.nacmoney.Size = new System.Drawing.Size(100, 21);
            this.nacmoney.TabIndex = 44;
            // 
            // nacadd
            // 
            this.nacadd.Location = new System.Drawing.Point(327, 48);
            this.nacadd.Name = "nacadd";
            this.nacadd.Size = new System.Drawing.Size(100, 21);
            this.nacadd.TabIndex = 43;
            // 
            // nactext
            // 
            this.nactext.Location = new System.Drawing.Point(120, 88);
            this.nactext.Name = "nactext";
            this.nactext.Size = new System.Drawing.Size(100, 21);
            this.nactext.TabIndex = 42;
            // 
            // nacname
            // 
            this.nacname.Location = new System.Drawing.Point(120, 48);
            this.nacname.Name = "nacname";
            this.nacname.Size = new System.Drawing.Size(100, 21);
            this.nacname.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 40;
            this.label13.Text = "总负责人：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "结束时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 38;
            this.label11.Text = "开始时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 37;
            this.label10.Text = "活动预算：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 36;
            this.label9.Text = "活动内容：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 35;
            this.label8.Text = "举办地点：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Location = new System.Drawing.Point(49, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 34;
            this.label7.Text = "活动名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nacname);
            this.groupBox1.Controls.Add(this.nacid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nacend);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nacstart);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nacpeople);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.nacmoney);
            this.groupBox1.Controls.Add(this.nactext);
            this.groupBox1.Controls.Add(this.nacadd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 220);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "活动申请信息";
            // 
            // ActivityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 285);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ActivityCheck";
            this.Text = "UPC社团内部管理系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nacid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nacend;
        private System.Windows.Forms.TextBox nacstart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nacpeople;
        private System.Windows.Forms.TextBox nacmoney;
        private System.Windows.Forms.TextBox nacadd;
        private System.Windows.Forms.TextBox nactext;
        private System.Windows.Forms.TextBox nacname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}