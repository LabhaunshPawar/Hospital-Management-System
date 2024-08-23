namespace HospitalManagementSystem
{
    partial class ViewPatientInfo
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
            txtsearchpatient = new TextBox();
            btnsearchpatient = new Button();
            grdataptview = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)grdataptview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 46);
            label1.Name = "label1";
            label1.Size = new Size(253, 30);
            label1.TabIndex = 0;
            label1.Text = "View Patient Information";
            // 
            // txtsearchpatient
            // 
            txtsearchpatient.Location = new Point(377, 150);
            txtsearchpatient.Name = "txtsearchpatient";
            txtsearchpatient.Size = new Size(157, 27);
            txtsearchpatient.TabIndex = 1;
            // 
            // btnsearchpatient
            // 
            btnsearchpatient.BackColor = Color.Teal;
            btnsearchpatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsearchpatient.ForeColor = Color.White;
            btnsearchpatient.Location = new Point(596, 139);
            btnsearchpatient.Name = "btnsearchpatient";
            btnsearchpatient.Size = new Size(147, 48);
            btnsearchpatient.TabIndex = 2;
            btnsearchpatient.Text = "Search Patient";
            btnsearchpatient.UseVisualStyleBackColor = false;
            btnsearchpatient.Click += btnsearchpatient_Click;
            // 
            // grdataptview
            // 
            grdataptview.BackgroundColor = SystemColors.Control;
            grdataptview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdataptview.Location = new Point(12, 247);
            grdataptview.Name = "grdataptview";
            grdataptview.RowHeadersWidth = 51;
            grdataptview.RowTemplate.Height = 29;
            grdataptview.Size = new Size(1138, 218);
            grdataptview.TabIndex = 3;
            grdataptview.CellContentClick += grdataptview_CellContentClick;
            // 
            // ViewPatientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1162, 623);
            Controls.Add(grdataptview);
            Controls.Add(btnsearchpatient);
            Controls.Add(txtsearchpatient);
            Controls.Add(label1);
            Name = "ViewPatientInfo";
            Text = "ViewPatientInfo";
            ((System.ComponentModel.ISupportInitialize)grdataptview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtsearchpatient;
        private Button btnsearchpatient;
        private DataGridView grdataptview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}