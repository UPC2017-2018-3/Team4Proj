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
    public partial class SthCheck : Form
    {
        public string id = "";
        public SthCheck(DataGridViewCellCollection dgvCC, string s)
        {
            InitializeComponent();
            ncdsq.Text = dgvCC[1].Value.ToString();
            ncdid.Text = dgvCC[2].Value.ToString();
            ncdname.Text = dgvCC[3].Value.ToString();
            ncdstart.Text = dgvCC[4].Value.ToString();
            ncdend.Text = dgvCC[5].Value.ToString();
            ncdbm.Text = dgvCC[6].Value.ToString();
            ncdreason.Text = dgvCC[7].Value.ToString();
            id = s;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='不通过',Check_AdminID='" + id + "' where project_applyID='" + ncdsq.Text + "'", conn);
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
            SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='通过',Check_AdminID='" + id + "' where project_applyID='" + ncdsq.Text + "'", conn);
            SqlCommand cmd2 = new SqlCommand("update [Article] set Article_State='在借' where Article_ID='" + ncdid.Text + "'", conn);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("审核通过！");
            this.Close();
        }

        private void ncdend_TextChanged(object sender, EventArgs e)
        {

        }

        private void ncdsq_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
