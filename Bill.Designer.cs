namespace HospitalManagementSystem
{
    partial class Bill
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnsearchpatient = new Button();
            txtsearchpatient = new TextBox();
            btnaddbill = new Button();
            txtremainingbill = new TextBox();
            label7 = new Label();
            txtpaidbill = new TextBox();
            label6 = new Label();
            txttotalbill = new TextBox();
            label5 = new Label();
            txtmedicinebill = new TextBox();
            label4 = new Label();
            txtdoctorbill = new TextBox();
            label3 = new Label();
            txtroombill = new TextBox();
            label2 = new Label();
            grdataptview = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            btnsearchpatientbill = new Button();
            txtsearchbill = new TextBox();
            grdatappbbview = new DataGridView();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdataptview).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdatappbbview).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1109, 579);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnsearchpatient);
            tabPage1.Controls.Add(txtsearchpatient);
            tabPage1.Controls.Add(btnaddbill);
            tabPage1.Controls.Add(txtremainingbill);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtpaidbill);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txttotalbill);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtmedicinebill);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtdoctorbill);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtroombill);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(grdataptview);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1101, 546);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Bill";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnsearchpatient
            // 
            btnsearchpatient.BackColor = Color.Teal;
            btnsearchpatient.ForeColor = Color.White;
            btnsearchpatient.Location = new Point(533, 74);
            btnsearchpatient.Name = "btnsearchpatient";
            btnsearchpatient.Size = new Size(147, 48);
            btnsearchpatient.TabIndex = 2;
            btnsearchpatient.Text = "Search Patient";
            btnsearchpatient.UseVisualStyleBackColor = false;
            btnsearchpatient.Click += btnsearchpatient_Click;
            // 
            // txtsearchpatient
            // 
            txtsearchpatient.Location = new Point(323, 85);
            txtsearchpatient.Name = "txtsearchpatient";
            txtsearchpatient.Size = new Size(157, 27);
            txtsearchpatient.TabIndex = 1;
            // 
            // btnaddbill
            // 
            btnaddbill.BackColor = Color.Teal;
            btnaddbill.ForeColor = Color.White;
            btnaddbill.Location = new Point(924, 478);
            btnaddbill.Name = "btnaddbill";
            btnaddbill.Size = new Size(120, 42);
            btnaddbill.TabIndex = 10;
            btnaddbill.Text = "Add Bill";
            btnaddbill.UseVisualStyleBackColor = false;
            btnaddbill.Click += btnaddbill_Click;
            // 
            // txtremainingbill
            // 
            txtremainingbill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtremainingbill.ForeColor = Color.Red;
            txtremainingbill.Location = new Point(720, 486);
            txtremainingbill.Name = "txtremainingbill";
            txtremainingbill.ReadOnly = true;
            txtremainingbill.Size = new Size(82, 27);
            txtremainingbill.TabIndex = 9;
            txtremainingbill.Validating += txtpaidbill_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(588, 489);
            label7.Name = "label7";
            label7.Size = new Size(133, 20);
            label7.TabIndex = 30;
            label7.Text = "Remaining Bill : =";
            // 
            // txtpaidbill
            // 
            txtpaidbill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpaidbill.ForeColor = Color.DarkGreen;
            txtpaidbill.Location = new Point(484, 486);
            txtpaidbill.Name = "txtpaidbill";
            txtpaidbill.Size = new Size(82, 27);
            txtpaidbill.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(374, 489);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 28;
            label6.Text = "Paid Bill :    =";
            // 
            // txttotalbill
            // 
            txttotalbill.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txttotalbill.Location = new Point(345, 441);
            txttotalbill.Name = "txttotalbill";
            txttotalbill.ReadOnly = true;
            txttotalbill.Size = new Size(82, 27);
            txttotalbill.TabIndex = 7;
            txttotalbill.Tag = "int";
            txttotalbill.Validating += txtmedicinebill_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(200, 444);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 26;
            label5.Text = "Total Bill :             =";
            // 
            // txtmedicinebill
            // 
            txtmedicinebill.Location = new Point(345, 395);
            txtmedicinebill.Name = "txtmedicinebill";
            txtmedicinebill.Size = new Size(82, 27);
            txtmedicinebill.TabIndex = 6;
            txtmedicinebill.Tag = "int";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 398);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 24;
            label4.Text = "Medicine Bill :      + ";
            // 
            // txtdoctorbill
            // 
            txtdoctorbill.Location = new Point(345, 350);
            txtdoctorbill.Name = "txtdoctorbill";
            txtdoctorbill.Size = new Size(82, 27);
            txtdoctorbill.TabIndex = 5;
            txtdoctorbill.Tag = "int";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 353);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 22;
            label3.Text = "Doctor Bill :          +";
            // 
            // txtroombill
            // 
            txtroombill.Location = new Point(345, 307);
            txtroombill.Name = "txtroombill";
            txtroombill.Size = new Size(82, 27);
            txtroombill.TabIndex = 4;
            txtroombill.Tag = "int";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 310);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 20;
            label2.Text = "Room Bill :  2000   *";
            // 
            // grdataptview
            // 
            grdataptview.BackgroundColor = Color.White;
            grdataptview.ColumnHeadersHeight = 29;
            grdataptview.Location = new Point(31, 128);
            grdataptview.Name = "grdataptview";
            grdataptview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grdataptview.RowHeadersWidth = 51;
            grdataptview.RowTemplate.Height = 29;
            grdataptview.Size = new Size(1051, 168);
            grdataptview.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(416, 19);
            label1.Name = "label1";
            label1.Size = new Size(172, 33);
            label1.TabIndex = 18;
            label1.Text = "Add Bill Detail";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(btnsearchpatientbill);
            tabPage2.Controls.Add(txtsearchbill);
            tabPage2.Controls.Add(grdatappbbview);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1101, 546);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bill Report";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1060, 161);
            dataGridView1.TabIndex = 4;
            // 
            // btnsearchpatientbill
            // 
            btnsearchpatientbill.BackColor = Color.Teal;
            btnsearchpatientbill.ForeColor = Color.White;
            btnsearchpatientbill.Location = new Point(538, 85);
            btnsearchpatientbill.Name = "btnsearchpatientbill";
            btnsearchpatientbill.Size = new Size(147, 48);
            btnsearchpatientbill.TabIndex = 2;
            btnsearchpatientbill.Text = "Search Patient Bill";
            btnsearchpatientbill.UseVisualStyleBackColor = false;
            btnsearchpatientbill.Click += btnsearchpatientbill_Click;
            // 
            // txtsearchbill
            // 
            txtsearchbill.Location = new Point(328, 96);
            txtsearchbill.Name = "txtsearchbill";
            txtsearchbill.Size = new Size(157, 27);
            txtsearchbill.TabIndex = 1;
            // 
            // grdatappbbview
            // 
            grdatappbbview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdatappbbview.Location = new Point(25, 139);
            grdatappbbview.Name = "grdatappbbview";
            grdatappbbview.RowHeadersWidth = 51;
            grdatappbbview.RowTemplate.Height = 29;
            grdatappbbview.Size = new Size(1060, 161);
            grdatappbbview.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(434, 23);
            label8.Name = "label8";
            label8.Size = new Size(131, 33);
            label8.TabIndex = 35;
            label8.Text = "Bill Report";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 637);
            Controls.Add(tabControl1);
            Name = "Bill";
            Text = "l";
            Load += Bill_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdataptview).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdatappbbview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnaddbill;
        private TextBox txtremainingbill;
        private Label label7;
        private TextBox txtpaidbill;
        private Label label6;
        private TextBox txttotalbill;
        private Label label5;
        private TextBox txtmedicinebill;
        private Label label4;
        private TextBox txtdoctorbill;
        private Label label3;
        private TextBox txtroombill;
        private Label label2;
        private DataGridView grdataptview;
        private Label label1;
        private TabPage tabPage2;
        private Button btnsearchpatient;
        private TextBox txtsearchpatient;
        private Button btnsearchpatientbill;
        private TextBox txtsearchbill;
        private DataGridView grdatappbbview;
        private Label label8;
        private DataGridView dataGridView1;
    }
}