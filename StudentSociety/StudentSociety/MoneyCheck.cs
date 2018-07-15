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
    public partial class MoneyCheck : Form
    {
        public string id = "";
        public MoneyCheck(DataGridViewCellCollection dgvCC, string s)
        {
            InitializeComponent();
            njfid.Text = dgvCC[1].Value.ToString();
            njfmoney.Text = dgvCC[2].Value.ToString();
            njfbm.Text = dgvCC[3].Value.ToString();
            njfnr.Text = dgvCC[4].Value.ToString();
            njfpeople.Text = dgvCC[5].Value.ToString();
            id = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=154.8.169.229;Initial Catalog=StudentSociety_SQL;User ID=psn;Password=student=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='不通过',Check_AdminID='" + id + "' where project_applyID='" + njfid.Text + "'", conn);
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
            SqlCommand cmd = new SqlCommand("update [Project] set Check_Result='通过',Check_AdminID='" + id + "' where project_applyID='" + njfid.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("审核通过！");
            this.Close();
        }
    }
}
