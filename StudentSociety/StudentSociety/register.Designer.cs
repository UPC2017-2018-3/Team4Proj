namespace StudentSociety
{
    partial class register
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.apply = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.setpassword = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.sexgirl = new System.Windows.Forms.RadioButton();
            this.sexboy = new System.Windows.Forms.RadioButton();
            this.school = new System.Windows.Forms.ComboBox();
            this.depart = new System.Windows.Forms.ComboBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.apply);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.setpassword);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.sexgirl);
            this.groupBox1.Controls.Add(this.sexboy);
            this.groupBox1.Controls.Add(this.school);
            this.groupBox1.Controls.Add(this.depart);
            this.groupBox1.Controls.Add(this.grade);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(521, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户注册";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(440, 250);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 30);
            this.apply.TabIndex = 19;
            this.apply.Text = "申请";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.button2_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(340, 250);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 30);
            this.reset.TabIndex = 18;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // setpassword
            // 
            this.setpassword.Location = new System.Drawing.Point(347, 198);
            this.setpassword.Name = "setpassword";
            this.setpassword.Size = new System.Drawing.Size(100, 26);
            this.setpassword.TabIndex = 17;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(318, 148);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(129, 26);
            this.phone.TabIndex = 16;
            // 
            // sexgirl
            // 
            this.sexgirl.AutoSize = true;
            this.sexgirl.Location = new System.Drawing.Point(365, 50);
            this.sexgirl.Name = "sexgirl";
            this.sexgirl.Size = new System.Drawing.Size(41, 23);
            this.sexgirl.TabIndex = 15;
            this.sexgirl.TabStop = true;
            this.sexgirl.Text = "女";
            this.sexgirl.UseVisualStyleBackColor = true;
            // 
            // sexboy
            // 
            this.sexboy.AutoSize = true;
            this.sexboy.Location = new System.Drawing.Point(318, 50);
            this.sexboy.Name = "sexboy";
            this.sexboy.Size = new System.Drawing.Size(41, 23);
            this.sexboy.TabIndex = 14;
            this.sexboy.TabStop = true;
            this.sexboy.Text = "男";
            this.sexboy.UseVisualStyleBackColor = true;
            // 
            // school
            // 
            this.school.FormattingEnabled = true;
            this.school.Items.AddRange(new object[] {
            "地球科学与技术学院",
            "石油工程学院",
            "化学工程学院",
            "机电工程学院",
            "信息与控制工程学院",
            "储运与建筑工程学院",
            "计算机与通讯工程学院",
            "经济管理学院",
            "理学院",
            "文学院",
            "马克思主义学院",
            "体育教学部"});
            this.school.Location = new System.Drawing.Point(318, 98);
            this.school.Name = "school";
            this.school.Size = new System.Drawing.Size(129, 27);
            this.school.TabIndex = 13;
            // 
            // depart
            // 
            this.depart.FormattingEnabled = true;
            this.depart.Items.AddRange(new object[] {
            "活动策划组",
            "活动组织部",
            "活动宣传部",
            "行政部",
            "财务部",
            "外联部"});
            this.depart.Location = new System.Drawing.Point(118, 199);
            this.depart.Name = "depart";
            this.depart.Size = new System.Drawing.Size(121, 27);
            this.depart.TabIndex = 12;
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "2018级",
            "2017级",
            "2016级",
            "2015级"});
            this.grade.Location = new System.Drawing.Point(118, 149);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(121, 27);
            this.grade.TabIndex = 11;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(118, 98);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(121, 26);
            this.number.TabIndex = 10;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(118, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 26);
            this.name.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label9.Location = new System.Drawing.Point(261, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "密码设置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label7.Location = new System.Drawing.Point(261, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "学院：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label6.Location = new System.Drawing.Point(261, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label5.Location = new System.Drawing.Point(261, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label4.Location = new System.Drawing.Point(60, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "部门：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label3.Location = new System.Drawing.Point(60, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "年级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label2.Location = new System.Drawing.Point(60, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "学号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 310);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "register";
            this.Text = "UPC社团内部管理系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox setpassword;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.RadioButton sexgirl;
        private System.Windows.Forms.RadioButton sexboy;
        private System.Windows.Forms.ComboBox school;
        private System.Windows.Forms.ComboBox depart;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox name;
    }
}