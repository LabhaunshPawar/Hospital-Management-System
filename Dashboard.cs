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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnapinfo_Click(object sender, EventArgs e)
        {
            AddPatientInfo api = new AddPatientInfo();
            api.Show();
        }

        private void btnvpinfo_Click(object sender, EventArgs e)
        {
            ViewPatientInfo vpi = new ViewPatientInfo();
            vpi.Show();
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Show();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            Payment pm = new Payment();
            pm.Show();
        }

        private void btndischarge_Click(object sender, EventArgs e)
        {
            Discharge ds = new Discharge();
            ds.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logout SuccessFully!!");
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
