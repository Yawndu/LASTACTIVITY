using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _045_ACT3_Piñera_Xadrian
{
    public partial class fmrLogin : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\DB-ACT3 (1).mdb";
        OleDbConnection conn;
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select username, password from account where username=@uname and password=@pword";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@uname", txtusername.Text);
            cmd.Parameters.AddWithValue("@pword", txtpassword.Text);

            OleDbDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                frmMain frm = new frmMain(rdr["username"].ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credentials are incorrect", "Credentials");
            }
            conn.Close();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
