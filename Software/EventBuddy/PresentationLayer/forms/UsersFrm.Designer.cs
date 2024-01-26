namespace PresentationLayer.forms
{
    partial class UsersFrm
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecline = new System.Windows.Forms.Button();
            this.dgvUserRequests = new System.Windows.Forms.DataGridView();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnShowEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(12, 45);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(776, 256);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEditUser.Location = new System.Drawing.Point(810, 253);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(175, 41);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Uredi korisnika";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisnici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zahtjevi za organizatora";
            // 
            // btnDecline
            // 
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDecline.Location = new System.Drawing.Point(810, 450);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(175, 41);
            this.btnDecline.TabIndex = 4;
            this.btnDecline.Text = "Odbij";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // dgvUserRequests
            // 
            this.dgvUserRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRequests.Location = new System.Drawing.Point(12, 346);
            this.dgvUserRequests.Name = "dgvUserRequests";
            this.dgvUserRequests.Size = new System.Drawing.Size(776, 167);
            this.dgvUserRequests.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAccept.Location = new System.Drawing.Point(810, 370);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(175, 41);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Prihvati";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnShowEvents
            // 
            this.btnShowEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnShowEvents.Location = new System.Drawing.Point(876, 12);
            this.btnShowEvents.Name = "btnShowEvents";
            this.btnShowEvents.Size = new System.Drawing.Size(127, 61);
            this.btnShowEvents.TabIndex = 7;
            this.btnShowEvents.Text = "Prikazi događaje";
            this.btnShowEvents.UseVisualStyleBackColor = true;
            this.btnShowEvents.Click += new System.EventHandler(this.btnShowEvents_Click);
            // 
            // UsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 539);
            this.Controls.Add(this.btnShowEvents);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.dgvUserRequests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UsersFrm";
            this.Text = "UsersFrm";
            this.Load += new System.EventHandler(this.UsersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.DataGridView dgvUserRequests;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnShowEvents;
    }
}