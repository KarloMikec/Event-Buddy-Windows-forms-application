namespace PresentationLayer
{
    partial class EventsFrm
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
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.btnSakrij = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(12, 12);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(1085, 597);
            this.dgvEvents.TabIndex = 0;
            // 
            // btnSakrij
            // 
            this.btnSakrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnSakrij.Location = new System.Drawing.Point(763, 639);
            this.btnSakrij.Name = "btnSakrij";
            this.btnSakrij.Size = new System.Drawing.Size(334, 50);
            this.btnSakrij.TabIndex = 1;
            this.btnSakrij.Text = "Sakrij";
            this.btnSakrij.UseVisualStyleBackColor = true;
            this.btnSakrij.Click += new System.EventHandler(this.btnSakrij_Click);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnShowUsers.Location = new System.Drawing.Point(12, 639);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(334, 50);
            this.btnShowUsers.TabIndex = 2;
            this.btnShowUsers.Text = "Prikaži korisnike";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // EventsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 701);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.btnSakrij);
            this.Controls.Add(this.dgvEvents);
            this.Name = "EventsFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button btnSakrij;
        private System.Windows.Forms.Button btnShowUsers;
    }
}

