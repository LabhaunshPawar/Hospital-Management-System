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
    public partial class AddPatientInfo : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-VBUU0RI1;Initial Catalog=Hospital;Integrated Security=True");

        public AddPatientInfo()
        {
            InitializeComponent();
        }

        private void AddPatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnadddata_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); SqlCommand cmd = new SqlCommand("sp_Patients", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PatientId", SqlDbType.NVarChar).Value = txtpid.Text;
                cmd.Parameters.Add("@PatientName", SqlDbType.NVarChar).Value = txtpname.Text;
                cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = cmbgender.Text;
                // Convert Age, Mobile, Pincode, RoomRate, Fees to appropriate data types
                cmd.Parameters.Add("@Age", SqlDbType.Int).Value = int.Parse(txtpage.Text);
                cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = txtmobile.Text;
                cmd.Parameters.Add("@PatientAddress", SqlDbType.NVarChar).Value = txtaddress.Text;
                cmd.Parameters.Add("@Pincode", SqlDbType.NVarChar).Value = txtpincode.Text;
                cmd.Parameters.Add("@VisitDate", SqlDbType.DateTime).Value = dtpvisitdate.Value;
                cmd.Parameters.Add("@HandleByDoctor", SqlDbType.NVarChar).Value = txthbdoctor.Text;
                cmd.Parameters.Add("@Disease", SqlDbType.NVarChar).Value = txtdisease.Text;
                cmd.Parameters.Add("@BloodGroup", SqlDbType.NVarChar).Value = cmbbloodgrp.Text;
                cmd.Parameters.Add("@RoomType", SqlDbType.NVarChar).Value = cmbroomtype.Text;
                // Assuming RoomRate and Fees are numeric, use appropriate data type
                cmd.Parameters.Add("@RoomRate", SqlDbType.Decimal).Value = decimal.Parse(cmbroomrate.Text);
                cmd.Parameters.Add("@AdmitDate", SqlDbType.DateTime).Value = dtpadmitdate.Value;
                cmd.Parameters.Add("@Fees", SqlDbType.Decimal).Value = decimal.Parse(txtfees.Text);
                cmd.ExecuteNonQuery(); MessageBox.Show("Added Patient Data Successfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            // Clear the form fields after successful addition
            ClearFormFields();
        }
        private void ClearFormFields()
        {
            txtpname.Text = "";
            cmbgender.Text = ""; txtpage.Text = "";
            txtmobile.Text = ""; txtaddress.Text = "";
            txtpincode.Text = ""; dtpvisitdate.Value = DateTime.Now;
            txthbdoctor.Text = ""; txtdisease.Text = "";
            cmbroomtype.Text = ""; cmbroomrate.Text = "";
            dtpadmitdate.Value = DateTime.Now; txtfees.Text = "";
        }
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Tag != null && ct.Tag.ToString() == "double")
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || e.KeyChar == '\b'))
                {
                    e.KeyChar = (char)0;
                }
                if (ct.Text.Contains('.') && e.KeyChar == '.')
                {
                    e.KeyChar = (char)0;
                }
                int dotpos = ct.Text.IndexOf('.');

                if (dotpos >= 0 && e.KeyChar != '\b')
                {
                    if (ct.Text.Substring(dotpos).Length > 2)
                        e.KeyChar = (char)0;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtpaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtpincode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
