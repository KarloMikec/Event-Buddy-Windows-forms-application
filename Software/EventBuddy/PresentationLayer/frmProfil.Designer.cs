namespace PresentationLayer
{
    partial class frmProfil
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
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDarkTheme = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(38, 13);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbLanguage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(262, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moj Profil";
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(273, 141);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.ReadOnly = true;
            this.txtKorime.Size = new System.Drawing.Size(222, 20);
            this.txtKorime.TabIndex = 2;
            this.txtKorime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(273, 199);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(222, 20);
            this.txtOldPassword.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(273, 234);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(222, 20);
            this.txtNewPassword.TabIndex = 4;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Location = new System.Drawing.Point(273, 271);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.Size = new System.Drawing.Size(222, 20);
            this.txtNewPassword2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDarkTheme
            // 
            this.btnDarkTheme.Location = new System.Drawing.Point(586, 13);
            this.btnDarkTheme.Name = "btnDarkTheme";
            this.btnDarkTheme.Size = new System.Drawing.Size(97, 35);
            this.btnDarkTheme.TabIndex = 8;
            this.btnDarkTheme.Text = "Dark";
            this.btnDarkTheme.UseVisualStyleBackColor = true;
            // 
            // btnLight
            // 
            this.btnLight.Location = new System.Drawing.Point(689, 13);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(97, 35);
            this.btnLight.TabIndex = 9;
            this.btnLight.Text = "Light";
            this.btnLight.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.Location = new System.Drawing.Point(586, 393);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(200, 29);
            this.btnDeleteAcc.TabIndex = 10;
            this.btnDeleteAcc.Text = "Obriši račun";
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            // 
            // frmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.btnLight);
            this.Controls.Add(this.btnDarkTheme);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLanguage);
            this.Name = "frmProfil";
            this.Text = "frmProfil";
            this.Load += new System.EventHandler(this.frmProfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDarkTheme;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnDeleteAcc;
    }
}