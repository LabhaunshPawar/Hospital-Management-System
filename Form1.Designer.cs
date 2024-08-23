namespace HospitalManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnlogin = new Button();
            txtpwd = new TextBox();
            label2 = new Label();
            txtusername = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(360, 48);
            label3.Name = "label3";
            label3.Size = new Size(413, 40);
            label3.TabIndex = 5;
            label3.Text = "Hospital Management System";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnlogin);
            groupBox1.Controls.Add(txtpwd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtusername);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(173, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 266);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.ForestGreen;
            btnlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(177, 190);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(125, 38);
            btnlogin.TabIndex = 8;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtpwd
            // 
            txtpwd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtpwd.Location = new Point(177, 128);
            txtpwd.Name = "txtpwd";
            txtpwd.PasswordChar = '*';
            txtpwd.Size = new Size(125, 31);
            txtpwd.TabIndex = 7;
            txtpwd.Tag = "string";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 128);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtusername.Location = new Point(177, 70);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(125, 31);
            txtusername.TabIndex = 6;
            txtusername.Tag = "string";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 70);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 5;
            label1.Text = "LoginName";
            // 
            // pictureBox1
            // 
           // pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(675, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(382, 266);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1162, 623);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
           
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private GroupBox groupBox1;
        private Button btnlogin;
        private TextBox txtpwd;
        private Label label2;
        private TextBox txtusername;
        private Label label1;
        private PictureBox pictureBox1;
    }
}