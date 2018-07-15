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
    public partial class Userpage : Form
    {
        string sql = "";
        public string id;
        public Userpage(string s)
        {
            InitializeComponent();
            id = s;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Info_Revise info = new Info_Revise(id);
            info.ShowDialog();
            if (info.DialogResult == DialogResult.OK)
            {
                Userpage_Load(null, null);
            }
        }

        private void button8_Click(object sender, EventArgs e)//物品申请
        {
            if (Article_Number.Text == "" || Article_DepartID.Text == "" || Article_Start.Text == "" || Article_Finish.Text == "" || Article_Description.Text=="")
                MessageBox.Show("请填完整信息", "警告");
            else
            {
                string departID;
                switch (Article_DepartID.Text)
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
                SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
                con.Open();
                string myinsert = "insert into [Project](Article_ID,Article_DepartID,Article_Start,Article_Finish,apply_description,applicantID,Check_Result)" + " values ('" + Article_Number.Text + "','" + departID + "','" + Article_Start.Text + "','" + Article_Finish.Text + "','" + Article_Description.Text + "','" + id + "','未审核')";
                SqlCommand mycom = new SqlCommand(myinsert, con);           //定义OleDbCommnad对象并连接数据库
                mycom.ExecuteNonQuery();                       //执行插入语句
                con.Close();                //关闭对象并释放所占内存空间  
                con.Dispose();
                MessageBox.Show("申请成功，请等待审核！");
                Userpage_Load(null, null);
                Article_Reset_Click(null, null);
                
            }
        }

        private void button5_Click(object sender, EventArgs e)//经费申请
        {
            if (Expense_Money.Text == "" || Expense_DepartID.Text == "" || Expense_Description.Text == "")
                MessageBox.Show("请填完整信息", "警告");
            else
            {
                string departID;
                switch (Expense_DepartID.Text)
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
                SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
                con.Open();
                string myinsert = "insert into [Project](Expense_Money,Expense_DepartID,apply_description,applicantID,Check_Result)" + " values ('" + Expense_Money.Text + "','" + departID + "','" + Expense_Description.Text + "','" + id + "','未审核')";
                SqlCommand mycom = new SqlCommand(myinsert, con);           //定义OleDbCommnad对象并连接数据库
                mycom.ExecuteNonQuery();                       //执行插入语句
                con.Close();                //关闭对象并释放所占内存空间  
                con.Dispose();
                MessageBox.Show("申请成功，请等待审核！");
                Userpage_Load(null, null);
                Expense_Reset_Click(null, null);
            }
        }

        private void button3_Click(object sender, EventArgs e)//活动申请
        {
            if (Activity_Name.Text == "" || Activity_Description.Text == "" || Activity_FuzerenID.Text == "" )
            MessageBox.Show("请填完整信息", "警告");
            else
            { 
                    SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
                    con.Open();
                    string myinsert = "insert into [Project](Activity_Name,apply_description,Activity_Place,Activity_Budget,Activity_fuzerenID,Activity_Start,Activity_Finish,applicantID,Check_Result)" + " values ('" + Activity_Name.Text + "','" + Activity_Description.Text + "','" + Activity_Place.Text + "','"+Activity_Budget.Text+"','" + Activity_FuzerenID.Text + "','" + Activity_Start.Text+ "','" + Activity_Finish.Text + "','" + id + "','未审核')";
                    SqlCommand mycom = new SqlCommand(myinsert, con);           //定义OleDbCommnad对象并连接数据库
                    mycom.ExecuteNonQuery();                       //执行插入语句
                    con.Close();                //关闭对象并释放所占内存空间  
                    con.Dispose();
                MessageBox.Show("申请成功，请等待审核！");
                Userpage_Load(null, null);
                Activity_Reset_Click(null, null);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Welcome welcome1 = new Welcome();
            welcome1.Show();
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)//活动查询
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            sql = "";
            if (acid.Text.Trim() != string.Empty)
            {
                sql = " and [Project].project_applyID= '" + acid.Text.Trim() + "'";
            }
            if (acname.Text.Trim() != string.Empty)
            {
                sql += " and [Project].Activity_Name='" + acname.Text.Trim() + "'";
            }

            string s_sql = "select[Project].project_applyID as'活动编号',[Project].Activity_Start as '活动开始时间',[Project].Activity_Finish as'活动结束时间',[Project].Activity_Name as '活动名称',[Project].Activity_Place as '活动地点',[Project].Activity_Budget as '活动经费',[Project].Activity_FuzerenID as'负责人编号'FROM [Project] where [Project].Check_Result='通过' and [Project].Activity_Name is not null" + sql;
            SqlDataAdapter myda = new SqlDataAdapter(s_sql, sqlcon);
            DataSet myst = new DataSet();
            myda.Fill(myst);
            dgvac.DataSource = myst.Tables[0].DefaultView;

        }


        private void Activity_Reset_Click(object sender, EventArgs e)//活动申请重置
        {
            Activity_Name.Clear();
            Activity_Place.Clear();
            Activity_Description.Clear();
            Activity_Budget.Clear();
            Activity_FuzerenID.Clear();
            Activity_Start.Checked = false;
            Activity_Finish.Checked = false;

        }

        private void Article_Reset_Click(object sender, EventArgs e)//物品申请重置
        {
            Article_Number.Clear();
            Article_Description.Clear();
            Article_DepartID.SelectedIndex = -1;
            Article_Start.Checked = false;
            Article_Finish.Checked = false;
        }

        private void Expense_Reset_Click(object sender, EventArgs e)//经费申请重置
        {
            Expense_Money.Clear();
            Expense_Description.Clear();
            Expense_DepartID.SelectedIndex = -1;
        }


        private void button4_Click(object sender, EventArgs e)//经费查询
        {
            sql = "";
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            if (jfid.Text.Trim() != string.Empty)
            {
                sql = " and [Project].project_applyID= '" + jfid.Text.Trim() + "'";
            }
            if (jfbm.SelectedIndex>-1)
            {
                sql += " and [Department].Depart_Name= '" + jfbm.SelectedItem.ToString() + "'";
            }
            string s_sql = "select [Project].project_applyID as '经费编号',[Project].Expense_Money as '经费金额',[Department].Depart_Name as '经费申请部门',[Project].apply_description as '申请原因' FROM [Project],[Department] where [Project].Expense_DepartID=[Department].Depart_ID and [Project].Check_Result='通过' and [Project].Expense_Money is not null" + sql;
            SqlDataAdapter myda = new SqlDataAdapter(s_sql, sqlcon);
            DataSet myst = new DataSet();
            myst.Tables.Clear();
            myda.Fill(myst);
            dgvjf.DataSource = myst.Tables[0].DefaultView;
        }

        private void button7_Click(object sender, EventArgs e)//物品查询
        {
            sql = "";
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            if (cdid.Text.Trim() != string.Empty)
            {
                sql = " and Article_ID= '" + cdid.Text.Trim() + "'";
            }
            if (cdtext.Text.Trim() != string.Empty)
            {
                sql += " and Article_Description= '" + cdtext.Text.Trim() + "'";
            }
            string s_sql = "select Article_ID as '场地编号',Article_Description as '场地名称' , Article_State as '物品状态' from [Article] where not Article_State='报废' " + sql;
            SqlDataAdapter myda = new SqlDataAdapter(s_sql, sqlcon);
            DataSet myst = new DataSet();
            myst.Tables.Clear();
            myda.Fill(myst);
            dgvcd.DataSource = myst.Tables[0].DefaultView;
        }


        public void Userpage_Load(object sender, EventArgs e)//主页面
        {
            SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            con.Open();
            string s_ql = "select * from [User],[Department],[School] where User_ID= '" + id + "'and [User].Depart_ID=[Department].Depart_ID and [User].School_ID=[School].School_ID";
            SqlCommand cmd = new SqlCommand(s_ql, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                name.Text = sdr.GetString(sdr.GetOrdinal("User_Name"));
                number.Text = sdr.GetString(sdr.GetOrdinal("User_ID"));
                grade.Text = sdr.GetString(sdr.GetOrdinal("Grade"));
                depart.Text = sdr.GetString(sdr.GetOrdinal("Depart_Name"));
                actor.Text = sdr.GetString(sdr.GetOrdinal("Position"));
                sex.Text = sdr.GetString(sdr.GetOrdinal("Sex"));
                school.Text = sdr.GetString(sdr.GetOrdinal("School_Name"));
                phone.Text = sdr.GetString(sdr.GetOrdinal("Telephone"));
                password.Text = sdr.GetString(sdr.GetOrdinal("User_Pwd"));
                label_number.Text = sdr.GetString(sdr.GetOrdinal("User_ID"));
                label_name.Text = sdr.GetString(sdr.GetOrdinal("User_Name"));
                label_depart.Text = sdr.GetString(sdr.GetOrdinal("Depart_Name"));
                label_actor.Text = sdr.GetString(sdr.GetOrdinal("Position"));

            }
            sdr.Close();
            string ss_sql = "select [Project].project_applyID as '申请编号',[Project].Check_Result as '审核状态' FROM [Project] where [Project].applicantID='" + id + "' order by [Project].project_applyID desc" ;
            SqlDataAdapter myda = new SqlDataAdapter(ss_sql, con);
            DataSet myst = new DataSet();
            myda.Fill(myst);
            dataGridView4.DataSource = myst.Tables[0].DefaultView;
        }

        private void dgvac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
