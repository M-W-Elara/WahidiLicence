namespace WahidiLicence
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
            frmLicenseAgreement = new Label();
            lblCompany = new Label();
            lblUsers = new Label();
            txtCompanyName = new TextBox();
            txtNumberOfUsers = new TextBox();
            lstOutput = new ListBox();
            btnDisplay = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // frmLicenseAgreement
            // 
            frmLicenseAgreement.AutoSize = true;
            frmLicenseAgreement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            frmLicenseAgreement.Location = new Point(199, 59);
            frmLicenseAgreement.Name = "frmLicenseAgreement";
            frmLicenseAgreement.Size = new Size(227, 21);
            frmLicenseAgreement.TabIndex = 0;
            frmLicenseAgreement.Text = "Software License Agreement";
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Location = new Point(149, 130);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(97, 15);
            lblCompany.TabIndex = 1;
            lblCompany.Text = "Company Name:";
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Location = new Point(149, 165);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(99, 15);
            lblUsers.TabIndex = 2;
            lblUsers.Text = "Number of Users:";
            lblUsers.Click += lblUsers_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(282, 130);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 3;
            txtCompanyName.TextChanged += txtCompanyName_TextChanged;
            txtCompanyName.Enter += txtCompanyName_Enter;
            txtCompanyName.Leave += txtCompanyName_Leave;
            // 
            // txtNumberOfUsers
            // 
            txtNumberOfUsers.BackColor = SystemColors.GradientActiveCaption;
            txtNumberOfUsers.ForeColor = SystemColors.Window;
            txtNumberOfUsers.Location = new Point(282, 165);
            txtNumberOfUsers.Name = "txtNumberOfUsers";
            txtNumberOfUsers.Size = new Size(100, 23);
            txtNumberOfUsers.TabIndex = 4;
            txtNumberOfUsers.TextChanged += txtNumberOfUsers_TextChanged;
            txtNumberOfUsers.Enter += txtNumberOfUsers_Enter;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(183, 300);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(261, 124);
            lstOutput.TabIndex = 5;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(101, 235);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(97, 59);
            btnDisplay.TabIndex = 6;
            btnDisplay.Text = "&Calculate";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(254, 235);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 56);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(414, 235);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(97, 56);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 99);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 9;
            label1.Text = "Software Cost $100 per user:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplay);
            Controls.Add(lstOutput);
            Controls.Add(txtNumberOfUsers);
            Controls.Add(txtCompanyName);
            Controls.Add(lblUsers);
            Controls.Add(lblCompany);
            Controls.Add(frmLicenseAgreement);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label frmLicenseAgreement;
        private Label lblCompany;
        private Label lblUsers;
        private TextBox txtCompanyName;
        private TextBox txtNumberOfUsers;
        private ListBox lstOutput;
        private Button btnDisplay;
        private Button btnClear;
        private Button btnQuit;
        private Label label1;
    }
}
