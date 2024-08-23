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
    public partial class Discharge : Form
    {
        public Discharge()
        {
            InitializeComponent();
        }
       
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VBUU0RI1;Initial Catalog=Hospital;Integrated Security=True");

        private void btndischarge_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ViewPatients", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // Assuming you don't need to pass any parameters for this action
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            // Now you have the data in the DataTable dt, you can bind it to a grid view or handle it as needed
           // grdataptview.DataSource = dt;
        }

        private void btnsearchpatientbill_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-VBUU0RI1;Initial Catalog=Hospital;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ViewPatients", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // Assuming you're searching by patient name and you have a TextBox named txtsearchpatient
                cmd.Parameters.Add("@patientname", SqlDbType.NVarChar).Value = btnsearchpatientbill.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // Now you have the data in the DataTable dt, you can bind it to a grid view or handle it as needed
               // grdataptview.DataSource = dt;
            }
        }
    }
}
