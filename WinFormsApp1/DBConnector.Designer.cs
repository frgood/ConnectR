namespace DBDialog
{
    partial class DBConnector
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
            label1 = new Label();
            TxtServerName = new TextBox();
            BtnSave = new Button();
            label2 = new Label();
            label3 = new Label();
            CbxWindowsAuthentication = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            BtnCancel = new Button();
            BtnTest = new Button();
            TxtDatabase = new TextBox();
            TxTUsername = new TextBox();
            TxtPassword = new TextBox();
            groupBox1 = new GroupBox();
            CbxTrustServerCertificate = new CheckBox();
            CbxEncrypt = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 53);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Server Name:";
            // 
            // TxtServerName
            // 
            TxtServerName.Location = new Point(92, 50);
            TxtServerName.Name = "TxtServerName";
            TxtServerName.Size = new Size(257, 23);
            TxtServerName.TabIndex = 1;
            TxtServerName.TextChanged += FormTextChanged;
            // 
            // BtnSave
            // 
            BtnSave.Enabled = false;
            BtnSave.Location = new Point(245, 322);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(80, 36);
            BtnSave.TabIndex = 2;
            BtnSave.Text = "Okay";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 9);
            label2.Name = "label2";
            label2.Size = new Size(271, 15);
            label2.TabIndex = 3;
            label2.Text = "This is where a nice header will go that looks purty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 93);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Database:";
            // 
            // CbxWindowsAuthentication
            // 
            CbxWindowsAuthentication.AutoSize = true;
            CbxWindowsAuthentication.Checked = true;
            CbxWindowsAuthentication.CheckState = CheckState.Checked;
            CbxWindowsAuthentication.Location = new Point(92, 114);
            CbxWindowsAuthentication.Name = "CbxWindowsAuthentication";
            CbxWindowsAuthentication.Size = new Size(157, 19);
            CbxWindowsAuthentication.TabIndex = 5;
            CbxWindowsAuthentication.Text = "Windows Authentication";
            CbxWindowsAuthentication.UseVisualStyleBackColor = true;
            CbxWindowsAuthentication.CheckedChanged += FormTextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 142);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 171);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 7;
            label5.Text = "Password:";
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(331, 322);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(80, 36);
            BtnCancel.TabIndex = 8;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnTest
            // 
            BtnTest.Location = new Point(12, 329);
            BtnTest.Name = "BtnTest";
            BtnTest.Size = new Size(119, 23);
            BtnTest.TabIndex = 9;
            BtnTest.Text = "Test Connection";
            BtnTest.UseVisualStyleBackColor = true;
            BtnTest.Click += BtnTest_Click;
            // 
            // TxtDatabase
            // 
            TxtDatabase.Location = new Point(92, 85);
            TxtDatabase.Name = "TxtDatabase";
            TxtDatabase.Size = new Size(257, 23);
            TxtDatabase.TabIndex = 10;
            TxtDatabase.TextChanged += FormTextChanged;
            // 
            // TxTUsername
            // 
            TxTUsername.Enabled = false;
            TxTUsername.Location = new Point(92, 139);
            TxTUsername.Name = "TxTUsername";
            TxTUsername.Size = new Size(136, 23);
            TxTUsername.TabIndex = 11;
            TxTUsername.TextChanged += FormTextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Enabled = false;
            TxtPassword.Location = new Point(92, 168);
            TxtPassword.MaxLength = 256;
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(136, 23);
            TxtPassword.TabIndex = 12;
            TxtPassword.WordWrap = false;
            TxtPassword.TextChanged += FormTextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbxTrustServerCertificate);
            groupBox1.Controls.Add(CbxEncrypt);
            groupBox1.Location = new Point(92, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 103);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "SQL Server Parameters";
            // 
            // CbxTrustServerCertificate
            // 
            CbxTrustServerCertificate.AutoSize = true;
            CbxTrustServerCertificate.Checked = true;
            CbxTrustServerCertificate.CheckState = CheckState.Checked;
            CbxTrustServerCertificate.Location = new Point(6, 47);
            CbxTrustServerCertificate.Name = "CbxTrustServerCertificate";
            CbxTrustServerCertificate.Size = new Size(143, 19);
            CbxTrustServerCertificate.TabIndex = 1;
            CbxTrustServerCertificate.Text = "Trust Server Certificate";
            CbxTrustServerCertificate.UseVisualStyleBackColor = true;
            CbxTrustServerCertificate.CheckedChanged += FormTextChanged;
            // 
            // CbxEncrypt
            // 
            CbxEncrypt.AutoSize = true;
            CbxEncrypt.Location = new Point(6, 22);
            CbxEncrypt.Name = "CbxEncrypt";
            CbxEncrypt.Size = new Size(66, 19);
            CbxEncrypt.TabIndex = 0;
            CbxEncrypt.Text = "Encrypt";
            CbxEncrypt.UseVisualStyleBackColor = true;
            CbxEncrypt.CheckedChanged += FormTextChanged;
            // 
            // DBConnector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 370);
            Controls.Add(groupBox1);
            Controls.Add(TxtPassword);
            Controls.Add(TxTUsername);
            Controls.Add(TxtDatabase);
            Controls.Add(BtnTest);
            Controls.Add(BtnCancel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CbxWindowsAuthentication);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnSave);
            Controls.Add(TxtServerName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "DBConnector";
            Text = "Database Connection";
            TextChanged += FormTextChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtServerName;
        private Button BtnSave;
        private Label label2;
        private Label label3;
        private CheckBox CbxWindowsAuthentication;
        private Label label4;
        private Label label5;
        private Button BtnCancel;
        private Button BtnTest;
        private TextBox TxtDatabase;
        private TextBox TxTUsername;
        private TextBox TxtPassword;
        private GroupBox groupBox1;
        private CheckBox CbxEncrypt;
        private CheckBox CbxTrustServerCertificate;
    }
}
