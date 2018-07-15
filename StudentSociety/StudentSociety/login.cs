using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSociety
{
    public partial class login : Form
    {
        string character = "null";
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            register register1 = new register();
            register1.Show();
            this.Close();
        }

        private void loginbotton_Click(object sender, EventArgs e)
        {
            if (putong.Checked == true)
            {
                character = "普通用户";
            }
            if (admin.Checked == true)
            {
                character = "管理员";
            }
            if (nametextBox.Text == "" || keytextBox.Text == "" || character == "null")
            {
                MessageBox.Show("请填完整信息");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
                con.Open();
                string sql = "select * from [User] where User_ID= '" + nametextBox.Text.Trim() + "' and User_Pwd='" + keytextBox.Text.Trim() + "'and Character= '" + character + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr.HasRows)
                {
                    MessageBox.Show("登录成功");
                    if (character == "管理员")
                    {
                        Adminpage up = new Adminpage(keytextBox.Text);
                        up.Show();
                        this.Hide();
                    }
                    if (character == "普通用户")
                    {
                        Userpage up = new Userpage(keytextBox.Text);
                        up.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("您输入的用户名或密码错误，登录失败");
                }
                con.Close();
            }
        }

            
        private bool ValidateUserInput(string UserName, string Password)//判断用户名和密码是否完整
        {
            if (nametextBox.Text == string.Empty)
            {
                MessageBox.Show("用户名不能为空");
                return false;
            }
            if (keytextBox.Text == string.Empty)
            {
                MessageBox.Show("密码不能为空");
                return false;
            }
            return true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
