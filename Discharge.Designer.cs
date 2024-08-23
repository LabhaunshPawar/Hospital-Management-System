namespace HospitalManagementSystem
{
    partial class Discharge
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnsearchpatientbill = new Button();
            txtsearchbill = new TextBox();
            label8 = new Label();
            btndischarge = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnsearchpatientbill);
            groupBox1.Controls.Add(txtsearchbill);
            groupBox1.Location = new Point(113, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(853, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Discharge Patient";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 5;
            label1.Text = "Patient Name :";
            // 
            // btnsearchpatientbill
            // 
            btnsearchpatientbill.BackColor = Color.Teal;
            btnsearchpatientbill.ForeColor = Color.White;
            btnsearchpatientbill.Location = new Point(338, 16);
            btnsearchpatientbill.Name = "btnsearchpatientbill";
            btnsearchpatientbill.Size = new Size(147, 48);
            btnsearchpatientbill.TabIndex = 4;
            btnsearchpatientbill.Text = "SELECT";
            btnsearchpatientbill.UseVisualStyleBackColor = false;
            btnsearchpatientbill.Click += btnsearchpatientbill_Click;
            // 
            // txtsearchbill
            // 
            txtsearchbill.Location = new Point(158, 27);
            txtsearchbill.Name = "txtsearchbill";
            txtsearchbill.Size = new Size(157, 27);
            txtsearchbill.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(469, 24);
            label8.Name = "label8";
            label8.Size = new Size(201, 33);
            label8.TabIndex = 36;
            label8.Text = "Discharge Report";
            // 
            // btndischarge
            // 
            btndischarge.BackColor = Color.Red;
            btndischarge.ForeColor = Color.White;
            btndischarge.Location = new Point(776, 433);
            btndischarge.Name = "btndischarge";
            btndischarge.Size = new Size(147, 48);
            btndischarge.TabIndex = 37;
            btndischarge.Text = "Discharge";
            btndischarge.UseVisualStyleBackColor = false;
            btndischarge.Click += btndischarge_Click;
            // 
            // Discharge
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1162, 623);
            Controls.Add(btndischarge);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Name = "Discharge";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label8;
        private Label label1;
        private Button btnsearchpatientbill;
        private TextBox txtsearchbill;
        private Button btndischarge;
    }
}