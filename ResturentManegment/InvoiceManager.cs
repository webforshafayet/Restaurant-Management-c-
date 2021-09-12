using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturentManegment
{
    public partial class InvoiceManager : Form
    {
        public InvoiceManager()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=SHAFAYET;Initial Catalog=Resturent;Integrated Security=True");
        DataAccess db = new DataAccess();

        DataTable dt;
        SqlDataAdapter adpt;

        private void InvoiceManager_Load(object sender, EventArgs e)
        {
            GetInvoiceRecord();
        }

        private void GetInvoiceRecord()
        {



            SqlCommand cmd = new SqlCommand("select * from invoiceTable", db.con);

            DataTable dt = new DataTable();

            db.con.Open();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            db.con.Close();

            invoicedataGridView1.DataSource = dt;//grid view name
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform f = new Loginform();
            f.Show();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBoxSearch.Text);
        }

        public void SearchData(string search)
        {

            db.con.Open();
            string query = "select * from invoiceTable where fooditem like '%" + search + "%'";

            adpt = new SqlDataAdapter(query, db.con);
            dt = new DataTable();
            adpt.Fill(dt);
            invoicedataGridView1.DataSource = dt;
            db.con.Close();



        }

       
    }
}
