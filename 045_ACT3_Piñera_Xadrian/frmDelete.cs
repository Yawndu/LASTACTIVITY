﻿using System;
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
    public partial class frmDelete : Form
    {
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\DB-ACT3 (1).mdb";
        OleDbConnection conn;
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE from employee where name = @name and email = @email";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtDeleteName.Text);
            cmd.Parameters.AddWithValue("@email", txtDeleteEmail.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("RECORD DELETED. GOODLUCK", "GOODLUCK!!!!");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
