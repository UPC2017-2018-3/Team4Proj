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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Clear();
            number.Clear();
            grade.SelectedIndex = -1;
            depart.SelectedIndex = -1;
            school.SelectedIndex = -1;
            phone.Clear();
            setpassword.Clear();
            sexboy.Checked = false;
            sexgirl.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || number.Text == "" || setpassword.Text == "" || depart.SelectedItem == "" || ((sexboy.Checked == false) & (sexgirl.Checked == false)))
                MessageBox.Show("请填完整信息", "警告");
            else
            {
              SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
              con.Open();
              string sql = "select * from [User] where User_ID= '" + number.Text.Trim() + "'";
              SqlCommand cmd=new SqlCommand(sql,con);
              SqlDataReader sdr = cmd.ExecuteReader();
              sdr.Read();
              if (sdr.HasRows)
              MessageBox.Show("该用户已注册", "提示");
              else
              {
                    string sex;
                sdr.Close();
                SqlConnection conn = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
                conn.Open();
                    if (sexboy.Checked)
                        sex = "男";
                    else
                        sex = "女";
                    string schoolID;
                    switch (school.Text) {
                        case "地球科学与技术学院":
                            schoolID="001";break;
                        case "石油工程学院":
                            schoolID = "002"; break;
                        case "化学工程学院":
                            schoolID = "003"; break;
                        case "机电工程学院":
                            schoolID = "004"; break;
                        case "信息与控制工程学院":
                            schoolID = "005"; break;
                        case "储运与建筑工程学院":
                            schoolID = "006"; break;
                        case "计算机与通讯工程学院":
                            schoolID = "007"; break;
                        case "经济管理学院":
                            schoolID = "008"; break;
                        case "理学院":
                            schoolID = "009"; break;
                        case "文学院":
                            schoolID = "010"; break;
                        case "马克思主义学院":
                            schoolID = "011"; break;
                        default:
                            schoolID = "012";break;
                    }
                    /*string gradeID;
                    switch (grade.Text)
                    {
                        case "2018级":
                            gradeID = "001"; break;
                        case "2017级":
                            gradeID = "002"; break;
                        case "2016级":
                            gradeID = "003"; break;
                        default:
                            gradeID = "004"; break;
                    }*/
                    string departID;
                    switch (depart.Text)
                    {
                        case "活动策划组":
                            departID = "001"; break;
                        case "活动组织部":
                            departID = "002"; break;
                        case "活动宣传部":
                            departID = "003"; break;
                        case "行政部":
                            departID = "004"; break;
                        case "财务部":
                            departID = "005"; break;
                        case "外联部":
                            departID = "006"; break;
                        default:
                            departID = "007"; break;
                    }
                    string myinsert = "insert into [Project](New_ID,New_Name,New_Grade,New_DepartID,New_Sex,New_School,New_Telephone,New_Password,Check_Result)" + " values ('" + number.Text + "','" + name.Text + "','" + grade.Text + "','" + departID + "','" + sex + "','" + schoolID + "','" + phone.Text + "','" + setpassword.Text + "','未审核')";
                SqlCommand mycom = new SqlCommand(myinsert,conn);           //定义OleDbCommnad对象并连接数据库
                mycom.ExecuteNonQuery();                       //执行插入语句
                conn.Close();                //关闭对象并释放所占内存空间  
                conn.Dispose();
                MessageBox.Show("申请成功，请等待审核！");
                Welcome welcome1 = new Welcome();
                welcome1.Show();
                this.Close();
              }
            }
        }
    }
}
