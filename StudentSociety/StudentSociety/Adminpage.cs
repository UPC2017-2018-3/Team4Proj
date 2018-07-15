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

    public partial class Adminpage : Form
    {
        string sql = "";
        string ss;
        public Adminpage(string s)
        {
            InitializeComponent();
            ss = s;
            dgvcol(dgvacpass);
            dgvcol(jfpass);
            dgvcol(dgvcdpass);
            dgvcol(dgvpeopass);
        }
        private void dgvcol(DataGridView Data)//DataGridView中加入一列button
        {
            DataGridViewButtonColumn gigUrlColumn = new DataGridViewButtonColumn();
            gigUrlColumn.HeaderText = "操作";
            gigUrlColumn.Text = "审核";
            gigUrlColumn.UseColumnTextForButtonValue = true;
            gigUrlColumn.Width = 106;
            Data.Columns.Add(gigUrlColumn);

        }

        private void button12_Click(object sender, EventArgs e)//退出登录
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

        private void button4_Click(object sender, EventArgs e)//经费查询
        {
            sql = "";
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            if (jfid.Text.Trim() != string.Empty)
            {
                sql = " and [Project].project_applyID= '" + jfid.Text.Trim() + "'";
            }
            if (jfbm.SelectedIndex > -1)
            {
                sql += " and [Department].Depart_Name= '" + jfbm.SelectedItem.ToString() + "'";
            }
            string s_sql = "select [Project].project_applyID as '经费编号',[Project].Expense_Money as '经费金额',[Department].Depart_Name as '经费申请部门',[Project].apply_description as '申请原因' FROM [Project],[Department] where [Project].Expense_DepartID=[Department].Depart_ID and [Project].Check_Result='通过' and [Project].Expense_Money is not null" + sql;
            SqlDataAdapter myda = new SqlDataAdapter(s_sql, sqlcon);
            DataSet myst = new DataSet();
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
            myda.Fill(myst);
            dgvcd.DataSource = myst.Tables[0].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)//档案查询
        {
            sql = "";
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            if (stdno.Text.Trim() != string.Empty)
            {
                sql = " and User_ID= '" + stdno.Text.Trim() + "'";
            }
            if (stdname.Text.Trim() != string.Empty)
            {
                sql += " and User_Name= '" + stdname.Text.Trim() + "'";
            }
            string s_sql = "select [User].User_ID as '学工号',[User].User_Name as '姓名',[User].Sex as'性别', [Department].Depart_Name as '部门',[User].Position as '职务',[User].Telephone as'电话' from [User],[Department] where [User].Depart_ID=[Department].Depart_ID and 1=1 " + sql;
            SqlDataAdapter myda = new SqlDataAdapter(s_sql, sqlcon);
            DataSet myst = new DataSet();
            myda.Fill(myst);
            dgvda.DataSource = myst.Tables[0].DefaultView;
        }



        private void dgvacpass_CellContentClick_1(object sender, DataGridViewCellEventArgs e)//活动dgv点击事件
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgvacpass.Columns[e.ColumnIndex];

                if (column is DataGridViewButtonColumn)
                {
                    DataGridViewRow dgvrow = dgvacpass.Rows[e.RowIndex];
                    DataGridViewCellCollection dgvCC = dgvrow.Cells;
                    ActivityCheck up = new ActivityCheck(dgvCC, label_number.Text);
                    up.ShowDialog();
                    if (up.DialogResult == DialogResult.OK)
                    {
                        Adminpage_Load(null, null);
                    }
                }
            }
        }

        private void Adminpage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            con.Open();
            string s_ql = "select * from [User],[Department],[School] where User_ID= '" + ss + "'and [User].Depart_ID=[Department].Depart_ID and [User].School_ID=[School].School_ID";
            SqlCommand cmd = new SqlCommand(s_ql, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {

                label_number.Text = sdr.GetString(sdr.GetOrdinal("User_ID"));
                label_name.Text = sdr.GetString(sdr.GetOrdinal("User_Name"));
                label_actor.Text = sdr.GetString(sdr.GetOrdinal("Position"));

            }
            sdr.Close();
            string ss_sql = "select [Project].project_applyID as '申请编号',[Project].Check_Result as '审核状态' FROM [Project] where [Project].Check_Result='未审核'order by [Project].project_applyID desc";
            SqlDataAdapter myda = new SqlDataAdapter(ss_sql, con);
            DataSet myst = new DataSet();
            myda.Fill(myst);
            dataGridView9.DataSource = myst.Tables[0].DefaultView;

            /*SqlConnection con = new SqlConnection("Data Source=DESKTOP-KKN1PRD\\SQLEXPRESS;Initial Catalog=StudentSociety_SQL;Integrated Security=True");
            con.Open();*/

            string acsql = "select project_applyID as'活动编号',Activity_Start as '活动开始时间',Activity_Finish as'活动结束时间',Activity_Name as '活动名称',Activity_Place as '活动地点',Activity_Budget as '活动经费',[User].User_Name as'负责人',apply_description as'活动内容'FROM [Project],[User] where [Project].Activity_FuzerenID=[User].User_ID and Check_Result='未审核'and Activity_Name is not null";
            SqlDataAdapter mydaac = new SqlDataAdapter(acsql, con);
            //DataSet myst = new DataSet();
            myst.Tables.Clear();
            mydaac.Fill(myst);
            dgvacpass.DataSource = myst.Tables[0].DefaultView;
            //dgvcol(dgvacpass);


            string jfsql = "select [Project].project_applyID as '经费编号',[Project].Expense_Money as '经费金额',[Department].Depart_Name as '经费申请部门',[Project].apply_description as '申请原因',[User].User_Name as '申请人' FROM [Project],[Department],[User] where [Project].Expense_DepartID =[Department].Depart_ID and [Project].applicantID=[User].User_ID and [Project].Check_Result='未审核'and Expense_Money is not null";
            SqlDataAdapter mydajf = new SqlDataAdapter(jfsql, con);
            myst.Tables.Clear();
            mydajf.Fill(myst);
            jfpass.DataSource = myst.Tables[0].DefaultView;
            //dgvcol(jfpass);

            string cdsql = "select [Project].project_applyID as '物品申请编号',[Project].Article_ID as '物品编号',[Article].Article_Description as '物品名称' ,[Project].Article_Start as '物品申请开始时间',[Project].Article_Finish as '物品申请结束时间',[Department].Depart_Name as '物品申请部门',[Project].apply_description as '申请原因' from [Project],[Department],[Article] where [Project].Article_DepartID =[Department].Depart_ID and [Project].Article_ID=[Article].Article_ID and [Project].Check_Result='未审核'and [Project].Article_ID is not null";
            SqlDataAdapter mydacd = new SqlDataAdapter(cdsql, con);
            myst.Tables.Clear();
            mydacd.Fill(myst);
            dgvcdpass.DataSource = myst.Tables[0].DefaultView;
            //dgvcol(dgvcdpass);


            string peosql = "select [Project].project_applyID as '申请编号',[Project].New_ID as '学号',[Project].New_Name as '姓名',[Project].New_Grade as '年级',[Department].Depart_Name as '部门',[Project].New_Sex as '性别',[School].School_Name as '学院',[Project].New_Telephone as '联系方式',[Project].New_Password as '密码',[Project].applicantID as '申请人id' from [Project],[Department],[School] where [Project].New_DepartID =[Department].Depart_ID and [Project].New_School=[School].School_ID and [Project].Check_Result='未审核'and [Project].New_ID is not null";
            SqlDataAdapter mydapeo = new SqlDataAdapter(peosql, con);
            myst.Tables.Clear();
            mydapeo.Fill(myst);
            dgvpeopass.DataSource = myst.Tables[0].DefaultView;
            //dgvcol(dgvpeopass);

            string ptsql = "select [User].User_ID as '学工号',[User].User_Name as '姓名',[User].Character as'角色' from [User] where [User].Character='普通用户' ";
            SqlDataAdapter mydapt = new SqlDataAdapter(ptsql, con);
            myst.Tables.Clear();
            mydapt.Fill(myst);
            dataGridView1.DataSource = myst.Tables[0].DefaultView;

            string glsql = "select [User].User_ID as '学工号',[User].User_Name as '姓名',[User].Character as'角色' from [User] where [User].Character='管理员' ";
            SqlDataAdapter mydagl = new SqlDataAdapter(glsql, con);
            myst.Tables.Clear();
            mydagl.Fill(myst);
            dataGridView2.DataSource = myst.Tables[0].DefaultView;

            string tjcdsql = "select Article_ID as '物品编号',Article_Description as '物品描述',Article_Price as '物品价格',Article_State as '物品状态' from [Article]";
            SqlDataAdapter mydatjcd = new SqlDataAdapter(tjcdsql, con);
            myst.Tables.Clear();
            mydatjcd.Fill(myst);
            dataGridView3.DataSource = myst.Tables[0].DefaultView;

            string tjpeosql = "select User_ID as '学号',User_Name as '姓名',Grade as '年级',[Department].Depart_Name as '部门',Position as'职务',Sex as '性别',[School].School_Name as '学院',Telephone as '电话',User_Pwd as '密码'from [User],[School],[Department] where [User].Depart_ID =[Department].Depart_ID and [User].School_ID=[School].School_ID";
            SqlDataAdapter mydatjpeo = new SqlDataAdapter(tjpeosql, con);
            myst.Tables.Clear();
            mydatjpeo.Fill(myst);
            dataGridView4.DataSource = myst.Tables[0].DefaultView;
        }
        

        private void jfpass_CellContentClick(object sender, DataGridViewCellEventArgs e)//经费dgv点击事件
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = jfpass.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    DataGridViewRow dgvrow = jfpass.Rows[e.RowIndex];
                    DataGridViewCellCollection dgvCC = dgvrow.Cells;
                    MoneyCheck up = new MoneyCheck(dgvCC, label_number.Text);
                    up.ShowDialog();
                    if (up.DialogResult == DialogResult.OK)
                    {
                        Adminpage_Load(null, null);
                    }
                }
            }
        }

        private void dgvcdpass_CellContentClick(object sender, DataGridViewCellEventArgs e)//物品dgv点击事件
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgvcdpass.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    DataGridViewRow dgvrow = dgvcdpass.Rows[e.RowIndex];
                    DataGridViewCellCollection dgvCC = dgvrow.Cells;
                    SthCheck up = new SthCheck(dgvCC, label_number.Text);
                    up.ShowDialog();
                    if (up.DialogResult == DialogResult.OK)
                    {
                        Adminpage_Load(null, null);
                    }
                }
            }
        }

        private void dgvpeopass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgvpeopass.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    DataGridViewRow dgvrow = dgvpeopass.Rows[e.RowIndex];
                    DataGridViewCellCollection dgvCC = dgvrow.Cells;
                    shenqing up = new shenqing(dgvCC, label_number.Text);
                    up.ShowDialog();
                    if (up.DialogResult == DialogResult.OK)
                    {
                        Adminpage_Load(null, null);
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "";
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            if (textBox2.Text.Trim() != string.Empty)
            {
                sql = " and User_ID= '" + textBox2.Text.Trim() + "'";
            }
            if (textBox1.Text.Trim() != string.Empty)
            {
                sql += " and User_Name= '" + textBox1.Text.Trim() + "'";
            }
            string s_sql = "select [User].User_ID as '学工号',[User].User_Name as '姓名',[User].Character as'角色' from [User] where [User].Character='普通用户' " + sql;
            SqlDataAdapter myda = new SqlDataAdapter(s_sql, sqlcon);
            DataSet myst = new DataSet();
            myda.Fill(myst);

            dataGridView1.DataSource = myst.Tables[0].DefaultView;
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sql = "";
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            if (textBox4.Text.Trim() != string.Empty)
            {
                sql = " and User_ID= '" + textBox4.Text.Trim() + "'";
            }
            if (textBox3.Text.Trim() != string.Empty)
            {
                sql += " and User_Name= '" + textBox3.Text.Trim() + "'";
            }
            string s_sql = "select [User].User_ID as '学工号',[User].User_Name as '姓名',[User].Character as'角色' from [User] where [User].Character='管理员' " + sql;
            SqlDataAdapter myda = new SqlDataAdapter(s_sql, sqlcon);
            DataSet myst = new DataSet();
            myda.Fill(myst);

            dataGridView2.DataSource = myst.Tables[0].DefaultView;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView1.CurrentRow.Index;
            string peoid = dataGridView1.Rows[a].Cells["学工号"].Value.ToString();
            string s_sql = "update [User] set Character='管理员'where User_ID='" + peoid + "'";
            SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
            mycom.ExecuteNonQuery();
            sqlcon.Close();
            Adminpage_Load(null, null);
            MessageBox.Show("添加成功！");

        }


        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView2.CurrentRow.Index;
            string peoid = dataGridView2.Rows[a].Cells["学工号"].Value.ToString();
            string s_sql = "update [User] set[User].Character='普通用户'where [User].User_ID='" + peoid + "' ";
            SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
            mycom.ExecuteNonQuery();
            Adminpage_Load(null, null);
            MessageBox.Show("删除成功！");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)//添加物品
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            string s_sql = "insert into [Article] values ('" + textBox6.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox5.Text + "') ";
            SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
            mycom.ExecuteNonQuery();
            Adminpage_Load(null, null);
            MessageBox.Show("添加成功！");
            textBox6.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox7.Clear();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView3.CurrentRow.Index;
            string peoid = dataGridView3.Rows[a].Cells["物品编号"].Value.ToString();
            string s_sql = "update [Article] set Article_State='报废'where Article_ID='" + peoid + "' ";
            SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
            mycom.ExecuteNonQuery();
            Adminpage_Load(null, null);
            MessageBox.Show("删除成功！");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView3.CurrentRow.Index;
            string peoid = dataGridView3.Rows[a].Cells["物品编号"].Value.ToString();
            string s_sql = "update [Article] set Article_ID='" + textBox6.Text + "',Article_Description ='" + textBox8.Text + "',Article_Price ='" + textBox7.Text + "',Article_State='" + textBox5.Text + "'where Article_ID='" + peoid + "' ";
            SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
            mycom.ExecuteNonQuery();
            Adminpage_Load(null, null);
            MessageBox.Show("更改成功！");
            textBox6.Clear();
            textBox8.Clear();
            textBox5.Clear();
            textBox7.Clear();

        }

        private void Article_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView3.CurrentRow.Index;
            textBox6.Text = dataGridView3.Rows[a].Cells["物品编号"].Value.ToString();
            textBox8.Text = dataGridView3.Rows[a].Cells["物品描述"].Value.ToString();
            textBox7.Text = dataGridView3.Rows[a].Cells["物品价格"].Value.ToString();
            textBox5.Text = dataGridView3.Rows[a].Cells["物品状态"].Value.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            SqlCommand cmd3 = new SqlCommand("select * from [User] where User_ID='" + name.Text + "'", sqlcon);
            SqlDataReader sdr = cmd3.ExecuteReader();
            if (sdr.HasRows)
            { MessageBox.Show("该用户信息已存在", "提示"); }
            else
            {
                string schoolID;
                switch (school.Text)
                {
                    case "地球科学与技术学院":
                        schoolID = "001"; break;
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
                        schoolID = "012"; break;
                }
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
                sdr.Close();
                string s_sql = "insert into [User] values ('" + id.Text + "','" + departID + "','" + name.Text + "','" + sex.Text + "','" + phone.Text + "','" + pwd.Text + "','" + schoolID + "','" + grade.Text + "','" + actor.Text + "','普通用户') ";
                SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
                mycom.ExecuteNonQuery();
                Adminpage_Load(null, null);
                MessageBox.Show("添加成功！");
                id.Clear(); name.Clear(); sex.Clear(); pwd.Clear(); grade.SelectedIndex = 0;
                depart.SelectedIndex = 0; ; school.SelectedIndex = 0; ; actor.Clear(); phone.Clear();


            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView4.CurrentRow.Index;
            string peoid = dataGridView4.Rows[a].Cells["学号"].Value.ToString();
            string s_sql = "delete from [User] where User_ID='" + peoid + "' ";
            SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
            mycom.ExecuteNonQuery();
            Adminpage_Load(null, null);
            MessageBox.Show("删除成功！");

        }

        private void more_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView4.CurrentRow.Index;
            id.Text = dataGridView4.Rows[a].Cells["学号"].Value.ToString();
            name.Text = dataGridView4.Rows[a].Cells["姓名"].Value.ToString();
            grade.Text = dataGridView4.Rows[a].Cells["年级"].Value.ToString();
            depart.Text = dataGridView4.Rows[a].Cells["部门"].Value.ToString();
            actor.Text = dataGridView4.Rows[a].Cells["职务"].Value.ToString();
            sex.Text = dataGridView4.Rows[a].Cells["性别"].Value.ToString();
            school.Text = dataGridView4.Rows[a].Cells["学院"].Value.ToString();
            phone.Text = dataGridView4.Rows[a].Cells["电话"].Value.ToString();
            pwd.Text = dataGridView4.Rows[a].Cells["密码"].Value.ToString();


        }

        private void change_Click(object sender, EventArgs e)
        {
            string schoolID;
            switch (school.Text)
            {
                case "地球科学与技术学院":
                    schoolID = "001"; break;
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
                    schoolID = "012"; break;
            }
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
            SqlConnection sqlcon = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            sqlcon.Open();
            int a = dataGridView4.CurrentRow.Index;
            string peoid = dataGridView4.Rows[a].Cells["学号"].Value.ToString();
            string s_sql = "update [User] set User_ID='" + id.Text + "',Depart_ID='" + departID + "',User_Name='" + name.Text + "',Sex='" + sex.Text + "',Telephone='" + phone.Text + "',User_Pwd='" + pwd.Text + "',School_ID='" + schoolID + "',Grade='" + grade.Text + "',Position='" + actor.Text + "'where User_ID='" + peoid + "' ";
            SqlCommand mycom = new SqlCommand(s_sql, sqlcon);           //定义OleDbCommnad对象并连接数据库
            mycom.ExecuteNonQuery();
            Adminpage_Load(null, null);
            MessageBox.Show("更改成功！");
            id.Clear(); name.Clear(); sex.Clear(); pwd.Clear(); grade.SelectedIndex = 0;
            depart.SelectedIndex = 0; ; school.SelectedIndex = 0; ; actor.Clear(); phone.Clear();
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
