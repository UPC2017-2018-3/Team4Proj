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
    public partial class ActivityCheck : Form
    {
        
        public string id = "";
        public ActivityCheck(DataGridViewCellCollection dgvCC, string s)
        {
            InitializeComponent();
            nacid.Text = dgvCC[1].Value.ToString();//
            nacstart.Text = dgvCC[2].Value.ToString();
            nacend.Text = dgvCC[3].Value.ToString();
            nacname.Text = dgvCC[4].Value.ToString();
            nacadd.Text = dgvCC[5].Value.ToString();
            nacmoney.Text = dgvCC[6].Value.ToString();
            nacpeople.Text = dgvCC[7].Value.ToString();
            nactext.Text = dgvCC[8].Value.ToString();
            id = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='不通过',Check_AdminID='" + id + "' where project_applyID='" + nacid.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("审核不通过！");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='通过',Check_AdminID='" + id + "' where project_applyID='" + nacid.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("审核通过！");
            this.Close();
        }
    }
}
