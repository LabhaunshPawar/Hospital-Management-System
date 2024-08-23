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
    public partial class AddRooms : Form
    {
        SqlConnection con = new SqlConnection(" ");
        public AddRooms()
        {
            InitializeComponent();
        }

        private void btnadddata_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add_patients", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@HandleByDoctor", SqlDbType.NVarChar).Value = txthbdoctor.Text;
            cmd.Parameters.Add("@Disease", SqlDbType.NVarChar).Value = txtdisease.Text;
            cmd.Parameters.Add("@BloodGroup", SqlDbType.NVarChar).Value = cmbloodgroup.Text;
            cmd.Parameters.Add("@RoomType", SqlDbType.NVarChar).Value = cmbroomtype.Text;
            cmd.Parameters.Add("@RoomRate", SqlDbType.NVarChar).Value = cmbroomrate.Text;
            cmd.Parameters.Add("@AdmitDate", SqlDbType.NVarChar).Value = dtpadmitdate.Value;
            cmd.Parameters.Add("@Fees", SqlDbType.NVarChar).Value = txtfees.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Patient Data Successll!!");
            con.Close();
            txthbdoctor.Text = "";
            txtdisease.Text = "";
            cmbloodgroup.Text = "";
            cmbroomtype.Text = "";
            cmbroomrate.Text = "";
            dtpadmitdate.Value = DateTime.Now;
            txtfees.Text = "";
        }

        private void AddRooms_Load(object sender, EventArgs e)
        {

        }
    }
}
