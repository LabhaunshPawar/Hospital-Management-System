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
    public partial class ViewPatientInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VBUU0RI1;Initial Catalog=Hospital;Integrated Security=True");

        public ViewPatientInfo()
        {
            InitializeComponent();
        }

        private void btnsearchpatient_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ViewPatients", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@patientname", SqlDbType.NVarChar).Value = txtsearchpatient.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grdataptview.DataSource = dt;
            
            /*if (grdataptview.Rows.Count == 0)
            {
                MessageBox.Show("not Success!!");

            }
            else
            {
                MessageBox.Show(" Found ....!!");

            }
            con.Close();
        }

        private void ViewPatientInfo_Load(object sender, EventArgs e)
        {
            /* con.Open();
             SqlCommand cmd = new SqlCommand("ViewPatients", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add("@patientname", SqlDbType.NVarChar).Value = "";
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
             grdataptview.DataSource = dt;
             con.Close();*/
        }

        private void grdataptview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
