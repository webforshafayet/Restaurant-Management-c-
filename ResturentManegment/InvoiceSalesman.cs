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
    public partial class InvoiceSalesman : Form
    {
        public InvoiceSalesman()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=SHAFAYET;Initial Catalog=Resturent;Integrated Security=True");
        DataAccess db = new DataAccess();

        DataTable dt;
        SqlDataAdapter adpt;
        public int foodId;

        private void InvoiceSalesman_Load(object sender, EventArgs e)
        {
            GetFoodList();
            GetorderList();
        }
        
        private void GetFoodList()
        {



            SqlCommand cmd = new SqlCommand("select * from foodTable", db.con);

            DataTable dt = new DataTable();

            db.con.Open();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            db.con.Close();

            FoodListDataGridView.DataSource = dt;//grid view name
        }

        private void GetorderList()
        {



            SqlCommand cmd = new SqlCommand("select * from invoiceTable", db.con);

            DataTable dt = new DataTable();

            db.con.Open();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            db.con.Close();

            invoicedataGridView1.DataSource = dt;//grid view name
        }

        private void FoodListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = Convert.ToInt32(FoodListDataGridView.SelectedRows[0].Cells[0].Value);
            textFoodName.Text = FoodListDataGridView.SelectedRows[0].Cells[1].Value.ToString();

            textFoodPrice.Text = FoodListDataGridView.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void invoicedataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodId = Convert.ToInt32(invoicedataGridView1.SelectedRows[0].Cells[0].Value);
            textFoodName.Text = invoicedataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            textFoodPrice.Text = invoicedataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textFoodQuantity.Text = invoicedataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           // textTotal.Text = invoicedataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           // textDiscount.Text = invoicedataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            //textnettotal.Text = invoicedataGridView1.SelectedRows[0].Cells[6].Value.ToString();//nettotal===afterdiscount



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {

                int price, quantity, total,discount,nettotal,subtotal;

                quantity = int.Parse(textFoodQuantity.Text);
                price = int.Parse(textFoodPrice.Text);
                discount = int.Parse(textDiscount.Text);
                subtotal = int.Parse(textsubtotal.Text);
                total = quantity * price;
                textTotal.Text = "" + total;
                nettotal = total - discount;
                textnettotal.Text = "" + nettotal;
                subtotal = subtotal + nettotal;
                textsubtotal.Text = "" + subtotal;

                SqlCommand cmd = new SqlCommand("INSERT INTO invoiceTable VALUES(@fooditem,@foodprice,@quantity,@totalprice,@discount,@after_discount)", db.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fooditem", textFoodName.Text);
                cmd.Parameters.AddWithValue("@foodprice", textFoodPrice.Text);
                cmd.Parameters.AddWithValue("@quantity", textFoodQuantity.Text);
                
                cmd.Parameters.AddWithValue("@totalprice", textTotal.Text);
                cmd.Parameters.AddWithValue("@discount", textDiscount.Text);
                cmd.Parameters.AddWithValue("@after_discount", textnettotal.Text);


 


                db.con.Open();
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("New food is Successfully inserterd", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetorderList();
                ResetButton();
            }

        }
        private bool IsValid()
        {
            if (textFoodName.Text == string.Empty)
            {
                MessageBox.Show("Food Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void ResetButton()
        {
            foodId = 0;
            textFoodName.Clear();
            textFoodPrice.Clear();
            textFoodQuantity.Clear();
            textTotal.Clear();
            textnettotal.Clear();
            textDiscount.Clear();
            



            textFoodName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (foodId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE invoiceTable SET fooditem=@fooditem,quantity=@quantity WHERE id=@id", db.con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fooditem", textFoodName.Text);
                cmd.Parameters.AddWithValue("@quantity", textFoodQuantity.Text);
                cmd.Parameters.AddWithValue("@id", this.foodId);




                db.con.Open();
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("New food is Successfully Updated", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetorderList();
                ResetButton();

            }
            else
            {
                MessageBox.Show("please, Select to Update food Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (foodId > 0)
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM invoiceTable WHERE id=@id", db.con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@id", this.foodId);

                db.con.Open();
                cmd.ExecuteNonQuery();
                db.con.Close();
                MessageBox.Show("Food-item Information is Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetorderList();
                ResetButton();
            }
            else
            {
                MessageBox.Show("please, Select to Delete Food-item Information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void SearchData(string search)
        {

            db.con.Open();
            string query = "select * from foodTable where foodname like '%" + search + "%'";

            adpt = new SqlDataAdapter(query, db.con);
            dt = new DataTable();
            adpt.Fill(dt);
            FoodListDataGridView.DataSource = dt;
            db.con.Close();

        }

        private void textBoxFoodSearch_TextChanged_1(object sender, EventArgs e)
        {
            SearchData(textBoxFoodSearch.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform f = new Loginform();
            f.Show();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetButton();
             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textsubtotal.Clear();
        }

       
    }
}
