using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturentManegment
{
     
    public partial class Loginform : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=SHAFAYET;Initial Catalog=Resturent;Integrated Security=True");
        DataAccess db = new DataAccess();
        public Loginform()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("sp_resturent_login", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname",textName.Text);
                    cmd.Parameters.AddWithValue("@upass", textPassword.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if(rd.HasRows)
                    {
                        rd.Read();
                        if(rd[4].ToString()== "Manager")
                        {
                            DataAccess.type = "M";
                        }
                        else if(rd[4].ToString() == "Salesman")
                        {
                            DataAccess.type = "S";
                        }
                        Dashboard d = new Dashboard();
                        d.Show();
                        this.Hide();
                    }
                    else 
                    {
                        MessageBox.Show("Error Login");
                    }
                   
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid input..Please enter your valid username & password");
            }

        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
