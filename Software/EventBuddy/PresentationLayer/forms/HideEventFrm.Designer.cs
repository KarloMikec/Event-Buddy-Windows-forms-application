namespace PresentationLayer.forms
{
    partial class HideEventFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HideEventFrm));
            this.btnHideEvent = new System.Windows.Forms.Button();
            this.btnRemoveRole = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHideEvent
            // 
            this.btnHideEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnHideEvent.Location = new System.Drawing.Point(64, 92);
            this.btnHideEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHideEvent.Name = "btnHideEvent";
            this.btnHideEvent.Size = new System.Drawing.Size(249, 87);
            this.btnHideEvent.TabIndex = 1;
            this.btnHideEvent.Text = "Sakrij događaj sa slanjem upozorenja";
            this.btnHideEvent.UseVisualStyleBackColor = true;
            this.btnHideEvent.Click += new System.EventHandler(this.btnHideEvent_Click);
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRemoveRole.Location = new System.Drawing.Point(64, 187);
            this.btnRemoveRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(249, 86);
            this.btnRemoveRole.TabIndex = 2;
            this.btnRemoveRole.Text = "Makni ulogu organizatora";
            this.btnRemoveRole.UseVisualStyleBackColor = true;
            this.btnRemoveRole.Click += new System.EventHandler(this.btnRemoveRole_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQuit.Location = new System.Drawing.Point(64, 281);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(249, 86);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Odustani od sakrivanja";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // HideEventFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 444);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemoveRole);
            this.Controls.Add(this.btnHideEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HideEventFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.HideEventFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHideEvent;
        private System.Windows.Forms.Button btnRemoveRole;
        private System.Windows.Forms.Button btnQuit;
    }
}