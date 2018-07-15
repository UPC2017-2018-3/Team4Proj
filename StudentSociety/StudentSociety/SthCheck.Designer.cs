namespace StudentSociety
{
    partial class SthCheck
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ncdbm = new System.Windows.Forms.TextBox();
            this.ncdname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ncdsq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ncdend = new System.Windows.Forms.TextBox();
            this.ncdstart = new System.Windows.Forms.TextBox();
            this.ncdreason = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ncdid = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "不通过";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "通过";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ncdbm);
            this.groupBox7.Controls.Add(this.ncdname);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.ncdsq);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.ncdend);
            this.groupBox7.Controls.Add(this.ncdstart);
            this.groupBox7.Controls.Add(this.ncdreason);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.ncdid);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Location = new System.Drawing.Point(28, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(557, 239);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "借用申请信息";
            // 
            // ncdbm
            // 
            this.ncdbm.Location = new System.Drawing.Point(370, 37);
            this.ncdbm.Name = "ncdbm";
            this.ncdbm.Size = new System.Drawing.Size(156, 21);
            this.ncdbm.TabIndex = 28;
            // 
            // ncdname
            // 
            this.ncdname.Location = new System.Drawing.Point(111, 187);
            this.ncdname.Name = "ncdname";
            this.ncdname.Size = new System.Drawing.Size(141, 21);
            this.ncdname.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Location = new System.Drawing.Point(40, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "物品名称：";
            // 
            // ncdsq
            // 
            this.ncdsq.Location = new System.Drawing.Point(370, 187);
            this.ncdsq.Name = "ncdsq";
            this.ncdsq.Size = new System.Drawing.Size(156, 21);
            this.ncdsq.TabIndex = 25;
            this.ncdsq.TextChanged += new System.EventHandler(this.ncdsq_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(286, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "申请编号：";
            // 
            // ncdend
            // 
            this.ncdend.Location = new System.Drawing.Point(131, 137);
            this.ncdend.Name = "ncdend";
            this.ncdend.Size = new System.Drawing.Size(121, 21);
            this.ncdend.TabIndex = 23;
            this.ncdend.TextChanged += new System.EventHandler(this.ncdend_TextChanged);
            // 
            // ncdstart
            // 
            this.ncdstart.Location = new System.Drawing.Point(131, 87);
            this.ncdstart.Name = "ncdstart";
            this.ncdstart.Size = new System.Drawing.Size(121, 21);
            this.ncdstart.TabIndex = 22;
            // 
            // ncdreason
            // 
            this.ncdreason.Location = new System.Drawing.Point(370, 87);
            this.ncdreason.Name = "ncdreason";
            this.ncdreason.Size = new System.Drawing.Size(156, 71);
            this.ncdreason.TabIndex = 21;
            this.ncdreason.Text = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(286, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 20;
            this.label24.Text = "申请事由：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(286, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 18;
            this.label18.Text = "申请部门：";
            // 
            // ncdid
            // 
            this.ncdid.Location = new System.Drawing.Point(131, 37);
            this.ncdid.Name = "ncdid";
            this.ncdid.Size = new System.Drawing.Size(121, 21);
            this.ncdid.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 12);
            this.label19.TabIndex = 5;
            this.label19.Text = "借用结束时间：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(40, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 12);
            this.label23.TabIndex = 4;
            this.label23.Text = "借用开始时间：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label27.Location = new System.Drawing.Point(40, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "场地/物品编号：";
            // 
            // SthCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 316);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox7);
            this.Name = "SthCheck";
            this.Text = "UPC社团内部管理系统";
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox ncdbm;
        private System.Windows.Forms.TextBox ncdname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ncdsq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ncdend;
        private System.Windows.Forms.TextBox ncdstart;
        private System.Windows.Forms.RichTextBox ncdreason;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ncdid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
    }
}