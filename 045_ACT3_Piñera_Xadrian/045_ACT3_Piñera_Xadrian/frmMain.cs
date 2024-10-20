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
    
    public partial class frmMain : Form
    {
        string _username;
        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Kyle\\Downloads\\DB-ACT3 (1).mdb";
        OleDbConnection conn;
        public frmMain(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Welcome " + _username;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select name as NAME,email as EMAIL, sex as SEX, address as ADDRESS from employee where name like '%" + txtname.Text + "%' and sex = '" + cboSex.Text + "' ";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            grdResult.DataSource = dt;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "select name as NAME,email as EMAIL, sex as SEX, address as ADDRESS from employee where name like '%" + txtname.Text + "%' ";
            conn = new OleDbConnection(connStr);
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            adapter.Fill(dt);
            conn.Close();

            grdResult.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEdit edit = new frmEdit();
            edit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete delete = new frmDelete();
            delete.ShowDialog();
        }

        private void cboSex_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}
