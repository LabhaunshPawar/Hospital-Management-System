using System.Data;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VBUU0RI1;Initial Catalog=Hospital;Integrated Security=True");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtusername.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtpwd.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Login Success!!");
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed!!");
            }
            con.Close();
        }
       
    }
}