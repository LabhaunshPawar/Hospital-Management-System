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

namespace HospitalManagementSystem
{
    public partial class Payment : Form
    {

        public Payment()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VBUU0RI1;Initial Catalog=Hospital;Integrated Security=True");

        private void btnmake_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addpayment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@amount", SqlDbType.NChar).Value = txtamount.Text;
            cmd.Parameters.Add("@paymenttype", SqlDbType.NChar).Value = cmbpaymenttype.Text;
            cmd.Parameters.Add("@bankname", SqlDbType.NChar).Value = txtbankname.Text;
            cmd.Parameters.Add("@checkno", SqlDbType.NChar).Value = txtcheckno.Text;

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Payment done by CHECK !!");
                Discharge ds = new Discharge();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Payment Failed!!");
            }
            con.Close();
        }

        private void txtbankname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcheckno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
