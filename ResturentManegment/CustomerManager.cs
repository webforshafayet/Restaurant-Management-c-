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
    public partial class CustomerManager : Form
    {
        public CustomerManager()
        {
            InitializeComponent();
        }


        // SqlConnection con = new SqlConnection(@"Data Source=SHAFAYET;Initial Catalog=Resturent;Integrated Security=True");
        DataAccess db = new DataAccess();

        DataTable dt;
        SqlDataAdapter adpt;
        public int customerId;

        private void CustomerManager_Load(object sender, EventArgs e)
        {
            GetCustomersRecord();
        }

        private void GetCustomersRecord()
        {
             


            SqlCommand cmd = new SqlCommand("select * from CustomerResturent", db.con);

            DataTable dt = new DataTable();

            db.con.Open();


             
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            db.con.Close();

            customerRecordDataGridView.DataSource = dt;//grid view name
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerResturent VALUES(@name,@address,@mobile)", db.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", textCustomerName.Text);
                cmd.Parameters.AddWithValue("@address", textCustomerAddress.Text);
                cmd.Parameters.AddWithValue("@mobile", textCustomerMobile.Text);


                db.con.Open();
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("New Customer is Successfully inserterd", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCustomersRecord();
                ResetButton();
            }
        }

        private bool IsValid()
        {
            if(textCustomerName.Text==string.Empty)
            {
                MessageBox.Show("Customer Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetButton();
        }

        private void ResetButton()
        {
            customerId = 0;
            textCustomerName.Clear();
            textCustomerAddress.Clear();
            textCustomerMobile.Clear();

            textCustomerName.Focus();
        }

        private void customerRecordDataGridView_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerId = Convert.ToInt32(customerRecordDataGridView.SelectedRows[0].Cells[0].Value);
            textCustomerName.Text = customerRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            textCustomerAddress.Text = customerRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();

            textCustomerMobile.Text = customerRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customerId > 0)
            {
                    SqlCommand cmd = new SqlCommand("UPDATE CustomerResturent SET name=@name,address=@address,mobile=@mobile WHERE customerid=@customerid", db.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", textCustomerName.Text);
                    cmd.Parameters.AddWithValue("@address", textCustomerAddress.Text);
                    cmd.Parameters.AddWithValue("@mobile", textCustomerMobile.Text);
                    cmd.Parameters.AddWithValue("@customerid", this.customerId);

                    db.con.Open();
                    cmd.ExecuteNonQuery();
                    db.con.Close();
                    MessageBox.Show("Customer Information is Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetCustomersRecord();
                    ResetButton();

            }
            else
            {
                MessageBox.Show("please, Select to Update Customer Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (customerId > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM CustomerResturent WHERE customerid=@customerid", db.con);
                cmd.CommandType = CommandType.Text;
                 
                cmd.Parameters.AddWithValue("@customerid", this.customerId);

                db.con.Open();
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("Customer Information is Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetCustomersRecord();
                ResetButton();
            }
            else
            {
                MessageBox.Show("please, Select to Delete Customer Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchData(textBoxSearch.Text);

        }

        public void SearchData(string search)
        {

            db.con.Open();
            string query = "select * from CustomerResturent where Name like '%" + search + "%'";

            adpt = new SqlDataAdapter(query, db.con);
            dt = new DataTable();
            adpt.Fill(dt);
            customerRecordDataGridView.DataSource = dt;
            db.con.Close();

            

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

        
    }
}
