namespace StudentSociety
{
    partial class login
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
            this.admin = new System.Windows.Forms.RadioButton();
            this.putong = new System.Windows.Forms.RadioButton();
            this.keytextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbotton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.admin);
            this.groupBox1.Controls.Add(this.putong);
            this.groupBox1.Controls.Add(this.keytextBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loginbotton);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 239);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录界面";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(206, 164);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(59, 16);
            this.admin.TabIndex = 13;
            this.admin.TabStop = true;
            this.admin.Text = "管理员";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // putong
            // 
            this.putong.AutoSize = true;
            this.putong.Location = new System.Drawing.Point(129, 164);
            this.putong.Name = "putong";
            this.putong.Size = new System.Drawing.Size(71, 16);
            this.putong.TabIndex = 12;
            this.putong.TabStop = true;
            this.putong.Text = "普通用户";
            this.putong.UseVisualStyleBackColor = true;
            this.putong.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // keytextBox
            // 
            this.keytextBox.Location = new System.Drawing.Point(129, 106);
            this.keytextBox.Name = "keytextBox";
            this.keytextBox.Size = new System.Drawing.Size(121, 21);
            this.keytextBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "注册";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(129, 50);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(121, 21);
            this.nametextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "角  色：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "密  码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名：";
            // 
            // loginbotton
            // 
            this.loginbotton.Location = new System.Drawing.Point(195, 203);
            this.loginbotton.Name = "loginbotton";
            this.loginbotton.Size = new System.Drawing.Size(75, 23);
            this.loginbotton.TabIndex = 0;
            this.loginbotton.Text = "登录";
            this.loginbotton.UseVisualStyleBackColor = true;
            this.loginbotton.Click += new System.EventHandler(this.loginbotton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 278);
            this.Controls.Add(this.groupBox1);
            this.Name = "login";
            this.Text = "UPC社团管理系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton putong;
        private System.Windows.Forms.TextBox keytextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbotton;
    }
}