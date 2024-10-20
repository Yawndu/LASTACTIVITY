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

namespace _045_ACT3_Piñera_Xadrian
{
    public partial class frmEdit : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\DB-ACT3 (1).mdb";
        OleDbConnection conn;
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [employee] set name = @name, email = @email, address = @address where empid = " + txtEditID.Text + "";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtEditName.Text);
            cmd.Parameters.AddWithValue("@email", txtEditEmail.Text);
            cmd.Parameters.AddWithValue("@address", txtEditAddress.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("INPUT UPDATED");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
