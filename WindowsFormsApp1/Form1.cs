using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class_connect;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        delegate DataTable DelegateTab(string query);
        DelegateTab del;
        Connect con = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            del = con.ConDt;
            dataGridView1.DataSource = del("SELECT * FROM productmaterial_k_import1");
            del = con.ConDt;
            dataGridView2.DataSource = del("SELECT * FROM products_k_import1");
            del = con.ConDt;
            dataGridView3.DataSource = del("SELECT * FROM materials_short_k_import1");
            /*
            string Query = "SELECT * FROM productmaterial_k_import1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = con.ConDS(Query).Tables[0];
            string secQuery = "SELECT * FROM products_k_import1";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.DataSource = con.ConDS(secQuery).Tables[0];
            string Query3 = "SELECT * FROM materials_short_k_import1";
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.DataSource = con.ConDS(secQuery).Tables[0];
            */

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void For2Form_Click(object sender, EventArgs e)
        {
            UserControl1 form2 = new UserControl1();
            
        }
    }
}
