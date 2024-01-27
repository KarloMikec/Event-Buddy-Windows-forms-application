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
            this.btnSaveAsPDFUsers = new System.Windows.Forms.Button();
            this.btnSaveAsPDFRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(16, 55);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(1035, 315);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnEditUser.Location = new System.Drawing.Point(1080, 311);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(233, 50);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "Uredi korisnika";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Korisnici";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(16, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zahtjevi za organizatora";
            // 
            // btnDecline
            // 
            this.btnDecline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnDecline.Location = new System.Drawing.Point(1080, 554);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(233, 50);
            this.btnDecline.TabIndex = 4;
            this.btnDecline.Text = "Odbij";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // dgvUserRequests
            // 
            this.dgvUserRequests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserRequests.Location = new System.Drawing.Point(16, 426);
            this.dgvUserRequests.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserRequests.Name = "dgvUserRequests";
            this.dgvUserRequests.Size = new System.Drawing.Size(1035, 206);
            this.dgvUserRequests.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAccept.Location = new System.Drawing.Point(1080, 455);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(233, 50);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Prihvati";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnSaveAsPDFUsers
            // 
            this.btnSaveAsPDFUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveAsPDFUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDFUsers.Location = new System.Drawing.Point(855, 11);
            this.btnSaveAsPDFUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAsPDFUsers.Name = "btnSaveAsPDFUsers";
            this.btnSaveAsPDFUsers.Size = new System.Drawing.Size(196, 37);
            this.btnSaveAsPDFUsers.TabIndex = 20;
            this.btnSaveAsPDFUsers.Text = "Spremi kao PDF";
            this.btnSaveAsPDFUsers.UseVisualStyleBackColor = true;
            this.btnSaveAsPDFUsers.Click += new System.EventHandler(this.btnSaveAsPDFUsers_Click);
            // 
            // btnSaveAsPDFRequests
            // 
            this.btnSaveAsPDFRequests.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveAsPDFRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAsPDFRequests.Location = new System.Drawing.Point(855, 385);
            this.btnSaveAsPDFRequests.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAsPDFRequests.Name = "btnSaveAsPDFRequests";
            this.btnSaveAsPDFRequests.Size = new System.Drawing.Size(196, 37);
            this.btnSaveAsPDFRequests.TabIndex = 21;
            this.btnSaveAsPDFRequests.Text = "Spremi kao PDF";
            this.btnSaveAsPDFRequests.UseVisualStyleBackColor = true;
            this.btnSaveAsPDFRequests.Click += new System.EventHandler(this.btnSaveAsPDFRequests_Click);
            // 
            // UsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 663);
            this.Controls.Add(this.btnSaveAsPDFRequests);
            this.Controls.Add(this.btnSaveAsPDFUsers);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.dgvUserRequests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1369, 702);
            this.Name = "UsersFrm";
            this.Text = "Prikaz korisnika i zahtjeva za organizatore";
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
        private System.Windows.Forms.Button btnSaveAsPDFUsers;
        private System.Windows.Forms.Button btnSaveAsPDFRequests;
    }
}