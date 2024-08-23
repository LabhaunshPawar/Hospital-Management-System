namespace HospitalManagementSystem
{
    partial class AddRooms
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
            groupBox2 = new GroupBox();
            cmbroomrate = new ComboBox();
            cmbroomtype = new ComboBox();
            label12 = new Label();
            label14 = new Label();
            cmbloodgroup = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txthbdoctor = new TextBox();
            txtfees = new TextBox();
            label9 = new Label();
            dtpadmitdate = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            txtdisease = new TextBox();
            btnadddata = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbroomrate);
            groupBox2.Controls.Add(cmbroomtype);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(cmbloodgroup);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txthbdoctor);
            groupBox2.Controls.Add(txtfees);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(dtpadmitdate);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtdisease);
            groupBox2.Location = new Point(12, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(465, 373);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Patient Admit Detail";
            // 
            // cmbroomrate
            // 
            cmbroomrate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbroomrate.FormattingEnabled = true;
            cmbroomrate.Location = new Point(210, 229);
            cmbroomrate.Name = "cmbroomrate";
            cmbroomrate.Size = new Size(136, 28);
            cmbroomrate.TabIndex = 14;
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
            cmbroomtype.TabIndex = 13;
            cmbroomtype.Text = "Select";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 230);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 12;
            label12.Text = "Room Rate/Day ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(30, 181);
            label14.Name = "label14";
            label14.Size = new Size(88, 20);
            label14.TabIndex = 11;
            label14.Text = "Room Type ";
            // 
            // cmbloodgroup
            // 
            cmbloodgroup.AutoCompleteCustomSource.AddRange(new string[] { "A+", "B+", "AB+", "O+", "A-", "B-", "AB-", "O-" });
            cmbloodgroup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbloodgroup.FormattingEnabled = true;
            cmbloodgroup.Items.AddRange(new object[] { "Male", "Female" });
            cmbloodgroup.Location = new Point(210, 133);
            cmbloodgroup.Name = "cmbloodgroup";
            cmbloodgroup.Size = new Size(86, 28);
            cmbloodgroup.TabIndex = 10;
            cmbloodgroup.Text = "Select";
            // 
            // label8
            // 
            label8.AutoSize = true;
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
            txthbdoctor.TabIndex = 1;
            txthbdoctor.Tag = "string";
            // 
            // txtfees
            // 
            txtfees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtfees.Location = new Point(210, 321);
            txtfees.Name = "txtfees";
            txtfees.Size = new Size(187, 27);
            txtfees.TabIndex = 6;
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
            dtpadmitdate.TabIndex = 5;
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
            txtdisease.TabIndex = 3;
            txtdisease.Tag = "string";
            // 
            // btnadddata
            // 
            btnadddata.BackColor = Color.MediumSeaGreen;
            btnadddata.Location = new Point(281, 414);
            btnadddata.Name = "btnadddata";
            btnadddata.Size = new Size(156, 54);
            btnadddata.TabIndex = 11;
            btnadddata.Text = "Add Patient";
            btnadddata.UseVisualStyleBackColor = false;
            btnadddata.Click += btnadddata_Click;
            // 
            // AddRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 509);
            Controls.Add(btnadddata);
            Controls.Add(groupBox2);
            Name = "AddRooms";
            Text = "Admit Patient Detail";
            Load += AddRooms_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ComboBox cmbroomrate;
        private ComboBox cmbroomtype;
        private Label label12;
        private Label label14;
        private ComboBox cmbloodgroup;
        private Label label8;
        private Label label7;
        private TextBox txthbdoctor;
        private TextBox txtfees;
        private Label label9;
        private DateTimePicker dtpadmitdate;
        private Label label10;
        private Label label11;
        private TextBox txtdisease;
        private Button btnadddata;
    }
}