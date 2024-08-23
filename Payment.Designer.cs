namespace HospitalManagementSystem
{
    partial class Payment
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
            grdataptview = new DataGridView();
            btnsearchpatient = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtcheckno = new TextBox();
            label5 = new Label();
            txtbankname = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnmake = new Button();
            cmbpaymenttype = new ComboBox();
            label3 = new Label();
            txtamount = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtsearchbill = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdataptview).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // grdataptview
            // 
            grdataptview.BackgroundColor = SystemColors.Control;
            grdataptview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdataptview.Location = new Point(94, 393);
            grdataptview.Name = "grdataptview";
            grdataptview.RowHeadersWidth = 51;
            grdataptview.RowTemplate.Height = 29;
            grdataptview.Size = new Size(970, 218);
            grdataptview.TabIndex = 7;
            // 
            // btnsearchpatient
            // 
            btnsearchpatient.BackColor = Color.Teal;
            btnsearchpatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchpatient.ForeColor = Color.White;
            btnsearchpatient.Location = new Point(348, 16);
            btnsearchpatient.Name = "btnsearchpatient";
            btnsearchpatient.Size = new Size(171, 48);
            btnsearchpatient.TabIndex = 6;
            btnsearchpatient.Text = "Search Patient";
            btnsearchpatient.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(433, 33);
            label1.Name = "label1";
            label1.Size = new Size(254, 30);
            label1.TabIndex = 4;
            label1.Text = "PAYMENT INFORMATION";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 192);
            groupBox1.Controls.Add(txtcheckno);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtbankname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnmake);
            groupBox1.Controls.Add(cmbpaymenttype);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtamount);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(105, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(959, 189);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Payment";
            // 
            // txtcheckno
            // 
            txtcheckno.Location = new Point(629, 102);
            txtcheckno.Name = "txtcheckno";
            txtcheckno.Size = new Size(187, 27);
            txtcheckno.TabIndex = 12;
            txtcheckno.TextChanged += txtcheckno_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 192);
            label5.Location = new Point(514, 105);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 11;
            label5.Text = " Check No:";
            // 
            // txtbankname
            // 
            txtbankname.Location = new Point(629, 41);
            txtbankname.Name = "txtbankname";
            txtbankname.Size = new Size(187, 27);
            txtbankname.TabIndex = 10;
            txtbankname.TextChanged += txtbankname_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Location = new Point(514, 41);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 9;
            label4.Text = "Bank Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 255, 192);
            pictureBox1.Location = new Point(459, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(398, 133);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnmake
            // 
            btnmake.BackColor = Color.Teal;
            btnmake.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnmake.ForeColor = Color.White;
            btnmake.Location = new Point(106, 138);
            btnmake.Name = "btnmake";
            btnmake.Size = new Size(132, 48);
            btnmake.TabIndex = 7;
            btnmake.Text = "Make";
            btnmake.UseVisualStyleBackColor = false;
            btnmake.Click += btnmake_Click;
            // 
            // cmbpaymenttype
            // 
            cmbpaymenttype.FormattingEnabled = true;
            cmbpaymenttype.Items.AddRange(new object[] { "By Cash", "Check" });
            cmbpaymenttype.Location = new Point(123, 87);
            cmbpaymenttype.Name = "cmbpaymenttype";
            cmbpaymenttype.Size = new Size(94, 28);
            cmbpaymenttype.TabIndex = 3;
            cmbpaymenttype.Text = "Select";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 87);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Payment Type :";
            // 
            // txtamount
            // 
            txtamount.Location = new Point(123, 44);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(94, 27);
            txtamount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Amount :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtsearchbill);
            groupBox2.Controls.Add(btnsearchpatient);
            groupBox2.Location = new Point(94, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(970, 72);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment Info";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 30);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Patient Name :";
            // 
            // txtsearchbill
            // 
            txtsearchbill.Location = new Point(158, 27);
            txtsearchbill.Name = "txtsearchbill";
            txtsearchbill.Size = new Size(157, 27);
            txtsearchbill.TabIndex = 3;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 645);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grdataptview);
            Controls.Add(label1);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)grdataptview).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdataptview;
        private Button btnsearchpatient;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cmbpaymenttype;
        private Label label3;
        private TextBox txtamount;
        private TextBox txtcheckno;
        private Label label5;
        private TextBox txtbankname;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnmake;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtsearchbill;
    }
}