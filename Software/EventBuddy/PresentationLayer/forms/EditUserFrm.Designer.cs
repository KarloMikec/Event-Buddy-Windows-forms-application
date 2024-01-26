namespace PresentationLayer.forms
{
    partial class EditUserFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberOfWarnings = new System.Windows.Forms.TextBox();
            this.btnOrganizerBox = new System.Windows.Forms.Button();
            this.btnModBox = new System.Windows.Forms.Button();
            this.btnOrganizer = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(52, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Korisničko ime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(52, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj upozorenja:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtName.Location = new System.Drawing.Point(43, 38);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(246, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSurname.Location = new System.Drawing.Point(43, 90);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(246, 26);
            this.txtSurname.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtUsername.Location = new System.Drawing.Point(43, 143);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(246, 26);
            this.txtUsername.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(25, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Uloge:";
            // 
            // txtNumberOfWarnings
            // 
            this.txtNumberOfWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNumberOfWarnings.Location = new System.Drawing.Point(190, 175);
            this.txtNumberOfWarnings.Name = "txtNumberOfWarnings";
            this.txtNumberOfWarnings.ReadOnly = true;
            this.txtNumberOfWarnings.Size = new System.Drawing.Size(45, 26);
            this.txtNumberOfWarnings.TabIndex = 8;
            // 
            // btnOrganizerBox
            // 
            this.btnOrganizerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnOrganizerBox.Location = new System.Drawing.Point(25, 233);
            this.btnOrganizerBox.Name = "btnOrganizerBox";
            this.btnOrganizerBox.Size = new System.Drawing.Size(138, 73);
            this.btnOrganizerBox.TabIndex = 9;
            this.btnOrganizerBox.Text = "Organizator";
            this.btnOrganizerBox.UseVisualStyleBackColor = true;
            // 
            // btnModBox
            // 
            this.btnModBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnModBox.Location = new System.Drawing.Point(182, 233);
            this.btnModBox.Name = "btnModBox";
            this.btnModBox.Size = new System.Drawing.Size(138, 73);
            this.btnModBox.TabIndex = 10;
            this.btnModBox.Text = "Moderator";
            this.btnModBox.UseVisualStyleBackColor = true;
            // 
            // btnOrganizer
            // 
            this.btnOrganizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnOrganizer.Location = new System.Drawing.Point(25, 312);
            this.btnOrganizer.Name = "btnOrganizer";
            this.btnOrganizer.Size = new System.Drawing.Size(113, 40);
            this.btnOrganizer.TabIndex = 11;
            this.btnOrganizer.Text = "Dodaj ulogu";
            this.btnOrganizer.UseVisualStyleBackColor = true;
            this.btnOrganizer.Click += new System.EventHandler(this.btnOrganizer_Click);
            // 
            // btnMod
            // 
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnMod.Location = new System.Drawing.Point(200, 312);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(120, 40);
            this.btnMod.TabIndex = 12;
            this.btnMod.Text = "Dodaj ulogu";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQuit.Location = new System.Drawing.Point(25, 379);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(138, 49);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Odustani";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSave.Location = new System.Drawing.Point(182, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 49);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditUserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnOrganizer);
            this.Controls.Add(this.btnModBox);
            this.Controls.Add(this.btnOrganizerBox);
            this.Controls.Add(this.txtNumberOfWarnings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditUserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUserFrm";
            this.Load += new System.EventHandler(this.EditUserFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberOfWarnings;
        private System.Windows.Forms.Button btnOrganizerBox;
        private System.Windows.Forms.Button btnModBox;
        private System.Windows.Forms.Button btnOrganizer;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSave;
    }
}