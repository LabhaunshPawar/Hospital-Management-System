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
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VBUU0RI1;Initial Catalog=Hospital;Integrated Security=True");

        public Bill()
        {
            InitializeComponent();
        }


        private void btnsearchpatient_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ViewBillandInfoDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@patientname", SqlDbType.NVarChar).Value = txtsearchpatient.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdataptview.DataSource = dt;
            con.Close();

        }

        private void btnaddbill_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add_billdetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PatientName", SqlDbType.NVarChar).Value = txtsearchpatient.Text;
            cmd.Parameters.Add("@RoomBill", SqlDbType.Int).Value = txtroombill.Text;
            cmd.Parameters.Add("@DoctorBill", SqlDbType.Int).Value = txtdoctorbill.Text;
            cmd.Parameters.Add("@MedicineBill", SqlDbType.Int).Value = txtmedicinebill.Text;
            cmd.Parameters.Add("@TotalBill", SqlDbType.Int).Value = txtroombill.Text;
            cmd.Parameters.Add("@PaidBill", SqlDbType.Int).Value = txtpaidbill.Text;
            cmd.Parameters.Add("@RemainingBill", SqlDbType.Int).Value = txtremainingbill.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Bill Data Added Success!!");
            con.Close();
            txtsearchpatient.Text = "";
            txtroombill.Text = "";
            txtdoctorbill.Text = "";
            txtmedicinebill.Text = "";
            txtroombill.Text = "";
            txtpaidbill.Text = "";
            txtremainingbill.Text = "";

        }



        private void btnsearchpatientbill_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ViewBillandInfoDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PatientName", SqlDbType.NVarChar).Value = txtsearchbill.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //DataTable dt1 = new DataTable();
            da.Fill(dt);
            BindingSource dp = new BindingSource();
            dp.DataSource = dt;
            //da.Fill(dt1);
            grdatappbbview.DataSource = dp;
            //  dataGridView1.DataSource = dt1;

            con.Close();
        }
        private void txtpaidbill_Validating(object sender, CancelEventArgs e)
        {
            txtremainingbill.Text = (Convert.ToInt32(txttotalbill.Text) - Convert.ToInt32(txtpaidbill.Text)).ToString();

        }

        private void txtmedicinebill_Validating(object sender, CancelEventArgs e)
        {
            txttotalbill.Text = (Convert.ToInt32(txtroombill.Text) + Convert.ToInt32(txtdoctorbill.Text) + Convert.ToInt32(txtmedicinebill.Text)).ToString();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {

                tabPage1.BackColor = Color.Green;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                tabPage2.BackColor = Color.Red;
            }

        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
