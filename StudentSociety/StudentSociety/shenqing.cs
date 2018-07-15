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
    public partial class shenqing : Form
    {
        public string id = "";
        public string departid;
        public string schoolid;
        public string peopleid;
        public string zhiwu;
        public int cnt;
        public shenqing(DataGridViewCellCollection dgvCC, string s)
        {
            InitializeComponent();
            sqid.Text = dgvCC[1].Value.ToString();
            newid.Text = dgvCC[2].Value.ToString();
            newname.Text = dgvCC[3].Value.ToString();
            newgrade.Text = dgvCC[4].Value.ToString();
            newdepart.Text = dgvCC[5].Value.ToString();
            newsex.Text = dgvCC[6].Value.ToString();
            newschool.Text = dgvCC[7].Value.ToString();
            newphone.Text = dgvCC[8].Value.ToString();
            newpwd.Text = dgvCC[9].Value.ToString();
            peopleid = dgvCC[10].Value.ToString();
            id = s;

        }



        private void pass_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("select New_DepartID,New_School from [Project] where project_applyID='" + sqid.Text + "'", conn);
            SqlDataReader sdr = cmd3.ExecuteReader();
            while (sdr.Read())
            {
                departid = sdr.GetString(sdr.GetOrdinal("New_DepartID"));
                schoolid = sdr.GetString(sdr.GetOrdinal("New_School"));

            }
            sdr.Close();
            SqlCommand cmd7 = new SqlCommand("select Position from [User] where User_ID='" + peopleid + "'", conn);
            SqlDataReader sdr2 = cmd7.ExecuteReader();
            while (sdr2.Read())
            {
                zhiwu = sdr2.GetString(sdr2.GetOrdinal("Position"));

            }
            sdr2.Close();
            if (cnt != 0)
            {

                if (newid.Text == peopleid)
                {
                    SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='通过',Check_AdminID='" + id + "' where project_applyID='" + sqid.Text + "'", conn);
                    SqlCommand cmd2 = new SqlCommand("update [User] set User_ID='" + newid.Text + "', Grade='" + newgrade.Text + "',Telephone='" + newphone.Text + "',User_pwd='" + newpwd.Text + "',User_Name='" + newname.Text + "',Sex='" + newsex.Text + "',Depart_ID='" + departid + "',School_ID='" + schoolid + "'where User_ID='" + peopleid + "'", conn);

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    conn.Close();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("审核通过！");
                    this.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='通过',Check_AdminID='" + id + "' where project_applyID='" + sqid.Text + "'", conn);
                    SqlCommand cmd2 = new SqlCommand("Insert [User] values('" + newid.Text + "','" + departid + "','" + newname.Text + "','" + newsex.Text + "','" + newphone.Text + "','" + newpwd.Text + "','" + schoolid + "','" + newgrade.Text + "','" + zhiwu + "','普通用户')", conn);
                    SqlCommand cmd5 = new SqlCommand("update [Project] set applicantID='" + newid.Text + "'where applicantID='" + peopleid + "'", conn);
                    SqlCommand cmd6 = new SqlCommand("delete [User] where User_ID='" + peopleid + "'", conn);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();
                    cmd6.ExecuteNonQuery();
                    conn.Close();
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("审核通过！");
                    this.Close();
                }

            }
            else
            {
                SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='通过',Check_AdminID='" + id + "' where project_applyID='" + sqid.Text + "'", conn);
                SqlCommand cmd2 = new SqlCommand("Insert [User] values('" + newid.Text + "','" + departid + "','" + newname.Text + "','" + newsex.Text + "','" + newphone.Text + "','" + newpwd.Text + "','" + schoolid + "','" + newgrade.Text + "','部员','普通用户')", conn);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("审核通过！");
                this.Close();
            }

        }

        private void unpass_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='不通过',Check_AdminID='" + id + "' where project_applyID='" + sqid.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("审核不通过！");
            this.Close();
        }

        private void sqid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void shenqing_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            con.Open();
            string s_ql = "select * from [User],[Department],[School] where User_ID= '" + peopleid + "'and [User].Depart_ID=[Department].Depart_ID and [User].School_ID=[School].School_ID";
            SqlCommand cmd = new SqlCommand(s_ql, con);
            cnt = Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                name.Text = sdr.GetString(sdr.GetOrdinal("User_Name"));
                number.Text = sdr.GetString(sdr.GetOrdinal("User_ID"));
                grade.Text = sdr.GetString(sdr.GetOrdinal("Grade"));
                depart.Text = sdr.GetString(sdr.GetOrdinal("Depart_Name"));
                sex.Text = sdr.GetString(sdr.GetOrdinal("Sex"));
                school.Text = sdr.GetString(sdr.GetOrdinal("School_Name"));
                phone.Text = sdr.GetString(sdr.GetOrdinal("Telephone"));
                setpassword.Text = sdr.GetString(sdr.GetOrdinal("User_Pwd"));
            }
            sdr.Close();
        }




    }
}