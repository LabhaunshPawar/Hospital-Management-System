namespace HospitalManagementSystem
{
    partial class Dashboard
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
            pictureBox1 = new PictureBox();
            btnapinfo = new Button();
            btnvpinfo = new Button();
            btndischarge = new Button();
            btnbill = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnlogout = new Button();
            btnpayment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hptm21;
            pictureBox1.Location = new Point(29, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1089, 486);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnapinfo
            // 
            btnapinfo.BackColor = Color.Teal;
            btnapinfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnapinfo.ForeColor = Color.White;
            btnapinfo.Location = new Point(891, 48);
            btnapinfo.Name = "btnapinfo";
            btnapinfo.Size = new Size(203, 55);
            btnapinfo.TabIndex = 1;
            btnapinfo.Text = "Patient Info";
            btnapinfo.UseVisualStyleBackColor = false;
            btnapinfo.Click += btnapinfo_Click;
            // 
            // btnvpinfo
            // 
            btnvpinfo.BackColor = Color.Teal;
            btnvpinfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnvpinfo.ForeColor = Color.White;
            btnvpinfo.Location = new Point(891, 123);
            btnvpinfo.Name = "btnvpinfo";
            btnvpinfo.Size = new Size(203, 55);
            btnvpinfo.TabIndex = 2;
            btnvpinfo.Text = "View Patient Info";
            btnvpinfo.UseVisualStyleBackColor = false;
            btnvpinfo.Click += btnvpinfo_Click;
            // 
            // btndischarge
            // 
            btndischarge.BackColor = Color.Teal;
            btndischarge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndischarge.ForeColor = Color.White;
            btndischarge.Location = new Point(891, 347);
            btndischarge.Name = "btndischarge";
            btndischarge.Size = new Size(203, 55);
            btndischarge.TabIndex = 5;
            btndischarge.Text = "Discharge";
            btndischarge.UseVisualStyleBackColor = false;
            btndischarge.Click += btndischarge_Click;
            // 
            // btnbill
            // 
            btnbill.BackColor = Color.Teal;
            btnbill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnbill.ForeColor = Color.White;
            btnbill.Location = new Point(891, 200);
            btnbill.Name = "btnbill";
            btnbill.Size = new Size(203, 55);
            btnbill.TabIndex = 3;
            btnbill.Text = "Bill";
            btnbill.UseVisualStyleBackColor = false;
            btnbill.Click += btnbill_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Teal;
            btnlogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(891, 425);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(203, 55);
            btnlogout.TabIndex = 7;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnpayment
            // 
            btnpayment.BackColor = Color.Teal;
            btnpayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnpayment.ForeColor = Color.White;
            btnpayment.Location = new Point(891, 273);
            btnpayment.Name = "btnpayment";
            btnpayment.Size = new Size(203, 55);
            btnpayment.TabIndex = 4;
            btnpayment.Text = "Payment";
            btnpayment.UseVisualStyleBackColor = false;
            btnpayment.Click += btnpayment_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 623);
            Controls.Add(btnpayment);
            Controls.Add(btnlogout);
            Controls.Add(btnbill);
            Controls.Add(btndischarge);
            Controls.Add(btnvpinfo);
            Controls.Add(btnapinfo);
            Controls.Add(pictureBox1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnapinfo;
        private Button btnvpinfo;
        private Button btndischarge;
        private Button btnbill;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnlogout;
        private Button btnpayment;
    }
}