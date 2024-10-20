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
    public partial class frmAdd : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\DB-ACT3 (1).mdb";
        OleDbConnection conn;
        public frmAdd()
        {
            InitializeComponent();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT into [employee](name, email, sex, address) values(@name, @email, @sex, @address)";
            conn = new OleDbConnection(connStr);    
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtAddName.Text);
            cmd.Parameters.AddWithValue("@email", txtAddEmail.Text);
            cmd.Parameters.AddWithValue("@sex", cboAddSex.Text);
            cmd.Parameters.AddWithValue("@address", txtAddAddress.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("INPUT ADDED");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
