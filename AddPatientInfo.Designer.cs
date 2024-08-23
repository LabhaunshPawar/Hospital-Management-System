namespace HospitalManagementSystem
{
    partial class AddPatientInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtpname = new TextBox();
            txtaddress = new TextBox();
            label2 = new Label();
            txtpage = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dtpvisitdate = new DateTimePicker();
            btnadddata = new Button();
            groupBox1 = new GroupBox();
            txtpid = new TextBox();
            label15 = new Label();
            txtpincode = new TextBox();
            label13 = new Label();
            txtmobile = new TextBox();
            label6 = new Label();
            cmbgender = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            cmbroomrate = new ComboBox();
            cmbroomtype = new ComboBox();
            label12 = new Label();
            label14 = new Label();
            cmbbloodgrp = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txthbdoctor = new TextBox();
            txtfees = new TextBox();
            label9 = new Label();
            dtpadmitdate = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            txtdisease = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 68);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Patient Name";
            // 
            // txtpname
            // 
            txtpname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpname.Location = new Point(149, 65);
            txtpname.Name = "txtpname";
            txtpname.Size = new Size(181, 27);
            txtpname.TabIndex = 1;
            txtpname.Tag = "string";
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtaddress.Location = new Point(149, 262);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(181, 27);
            txtaddress.TabIndex = 5;
            txtaddress.Tag = "string";
            txtaddress.TextChanged += txtpaddress_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 262);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 0;
            label2.Text = "Address";
            // 
            // txtpage
            // 
            txtpage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpage.Location = new Point(149, 162);
            txtpage.Name = "txtpage";
            txtpage.Size = new Size(84, 27);
            txtpage.TabIndex = 3;
            txtpage.Tag = "int";
            txtpage.KeyPress += Control_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 166);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 0;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(27, 361);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 5;
            label5.Text = "Visit Date";
            // 
            // dtpvisitdate
            // 
            dtpvisitdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpvisitdate.Location = new Point(149, 357);
            dtpvisitdate.Name = "dtpvisitdate";
            dtpvisitdate.Size = new Size(181, 27);
            dtpvisitdate.TabIndex = 7;
            // 
            // btnadddata
            // 
            btnadddata.BackColor = Color.Teal;
            btnadddata.ForeColor = Color.White;
            btnadddata.Location = new Point(499, 539);
            btnadddata.Name = "btnadddata";
            btnadddata.Size = new Size(156, 54);
            btnadddata.TabIndex = 16;
            btnadddata.Text = "Add Patient Data";
            btnadddata.UseVisualStyleBackColor = false;
            btnadddata.Click += btnadddata_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtpid);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtpincode);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtmobile);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbgender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtpname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtaddress);
            groupBox1.Controls.Add(dtpvisitdate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtpage);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(85, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 445);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patient Form";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtpid
            // 
            txtpid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpid.Location = new Point(149, 26);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(181, 27);
            txtpid.TabIndex = 13;
            txtpid.Tag = "string";
            txtpid.TextChanged += textBox1_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(27, 33);
            label15.Name = "label15";
            label15.Size = new Size(73, 20);
            label15.TabIndex = 12;
            label15.Text = "Patient ID";
            // 
            // txtpincode
            // 
            txtpincode.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpincode.Location = new Point(149, 312);
            txtpincode.Name = "txtpincode";
            txtpincode.Size = new Size(181, 27);
            txtpincode.TabIndex = 6;
            txtpincode.Tag = "int";
            txtpincode.TextChanged += txtpincode_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(27, 312);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 11;
            label13.Text = "Pincode";
            // 
            // txtmobile
            // 
            txtmobile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtmobile.Location = new Point(149, 211);
            txtmobile.Name = "txtmobile";
            txtmobile.Size = new Size(181, 27);
            txtmobile.TabIndex = 4;
            txtmobile.Tag = "int";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(27, 211);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 9;
            label6.Text = "Mobile";
            // 
            // cmbgender
            // 
            cmbgender.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbgender.FormattingEnabled = true;
            cmbgender.Items.AddRange(new object[] { "Male", "Female" });
            cmbgender.Location = new Point(149, 111);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(84, 28);
            cmbgender.TabIndex = 2;
            cmbgender.Text = "Select";
            cmbgender.SelectedIndexChanged += cmbgender_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 111);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 7;
            label3.Text = "Gender";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbroomrate);
            groupBox2.Controls.Add(cmbroomtype);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(cmbbloodgrp);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txthbdoctor);
            groupBox2.Controls.Add(txtfees);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtpadmitdate);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtdisease);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(582, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 424);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Patient Admit Detail";
            // 
            // cmbroomrate
            // 
            cmbroomrate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbroomrate.FormattingEnabled = true;
            cmbroomrate.Items.AddRange(new object[] { "500", "1000", "3000" });
            cmbroomrate.Location = new Point(210, 229);
            cmbroomrate.Name = "cmbroomrate";
            cmbroomrate.Size = new Size(136, 28);
            cmbroomrate.TabIndex = 12;
            cmbroomrate.Text = "Select";
            // 
            // cmbroomtype
            // 
            cmbroomtype.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbroomtype.FormattingEnabled = true;
            cmbroomtype.Items.AddRange(new object[] { "General", "Special", "ICU" });
            cmbroomtype.Location = new Point(210, 181);
            cmbroomtype.Name = "cmbroomtype";
            cmbroomtype.Size = new Size(136, 28);
            cmbroomtype.TabIndex = 11;
            cmbroomtype.Text = "Select";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(27, 230);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 12;
            label12.Text = "Room Rate/Day ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(30, 181);
            label14.Name = "label14";
            label14.Size = new Size(88, 20);
            label14.TabIndex = 11;
            label14.Text = "Room Type ";
            // 
            // cmbbloodgrp
            // 
            cmbbloodgrp.AutoCompleteCustomSource.AddRange(new string[] { "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-" });
            cmbbloodgrp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbbloodgrp.FormattingEnabled = true;
            cmbbloodgrp.Items.AddRange(new object[] { "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-" });
            cmbbloodgrp.Location = new Point(210, 133);
            cmbbloodgrp.Name = "cmbbloodgrp";
            cmbbloodgrp.Size = new Size(86, 28);
            cmbbloodgrp.TabIndex = 10;
            cmbbloodgrp.Text = "Select";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(27, 136);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 9;
            label8.Text = "Blood Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 39);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 0;
            label7.Text = "Handle By Doctor";
            // 
            // txthbdoctor
            // 
            txthbdoctor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txthbdoctor.Location = new Point(210, 36);
            txthbdoctor.Name = "txthbdoctor";
            txthbdoctor.Size = new Size(187, 27);
            txthbdoctor.TabIndex = 8;
            txthbdoctor.Tag = "string";
            // 
            // txtfees
            // 
            txtfees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtfees.Location = new Point(210, 321);
            txtfees.Name = "txtfees";
            txtfees.Size = new Size(187, 27);
            txtfees.TabIndex = 14;
            txtfees.Tag = "int";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(27, 324);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 0;
            label9.Text = "charges / Fees";
            // 
            // dtpadmitdate
            // 
            dtpadmitdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpadmitdate.Location = new Point(210, 274);
            dtpadmitdate.Name = "dtpadmitdate";
            dtpadmitdate.Size = new Size(187, 27);
            dtpadmitdate.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(27, 86);
            label10.Name = "label10";
            label10.Size = new Size(136, 20);
            label10.TabIndex = 0;
            label10.Text = "Symptoms/Disease";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(27, 279);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 5;
            label11.Text = "Admit Date";
            // 
            // txtdisease
            // 
            txtdisease.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtdisease.Location = new Point(210, 86);
            txtdisease.Name = "txtdisease";
            txtdisease.Size = new Size(187, 27);
            txtdisease.TabIndex = 9;
            txtdisease.Tag = "string";
            // 
            // AddPatientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1162, 623);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnadddata);
            Name = "AddPatientInfo";
            Text = "AddPatientInfo";
            Load += AddPatientInfo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtpname;
        private TextBox txtaddress;
        private Label label2;
        private TextBox txtpage;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpvisitdate;
        private Button btnadddata;
        private GroupBox groupBox1;
        private TextBox txtpincode;
        private Label label13;
        private TextBox txtmobile;
        private Label label6;
        private ComboBox cmbgender;
        private Label label3;
        private GroupBox groupBox2;
        private ComboBox cmbroomrate;
        private ComboBox cmbroomtype;
        private Label label12;
        private Label label14;
        private ComboBox cmbbloodgrp;
        private Label label8;
        private Label label7;
        private TextBox txthbdoctor;
        private TextBox txtfees;
        private Label label9;
        private DateTimePicker dtpadmitdate;
        private Label label10;
        private Label label11;
        private TextBox txtdisease;
        private TextBox txtpid;
        private Label label15;
    }
}