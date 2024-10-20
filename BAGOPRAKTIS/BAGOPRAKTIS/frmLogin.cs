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

namespace BAGOPRAKTIS
{
    public partial class frmLogin : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\DB-ACT3 (1).mdb";
        OleDbConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select username, password from account where username = @uname and password = @pword ";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@uname", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pword", txtPassword.Text);

            OleDbDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                frmMain frm = new frmMain(rdr["username"].ToString());
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Credentials");
            }
            conn.Close();
        }
    }
}
