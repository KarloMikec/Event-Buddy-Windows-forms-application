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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHideEvent = new System.Windows.Forms.Button();
            this.btnRemoveRole = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(41, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sakriti događaj od organizatora";
            // 
            // btnHideEvent
            // 
            this.btnHideEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnHideEvent.Location = new System.Drawing.Point(68, 126);
            this.btnHideEvent.Name = "btnHideEvent";
            this.btnHideEvent.Size = new System.Drawing.Size(199, 72);
            this.btnHideEvent.TabIndex = 1;
            this.btnHideEvent.Text = "Sakrij događaj sa slanjem upozorenja";
            this.btnHideEvent.UseVisualStyleBackColor = true;
            this.btnHideEvent.Click += new System.EventHandler(this.btnHideEvent_Click);
            // 
            // btnRemoveRole
            // 
            this.btnRemoveRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnRemoveRole.Location = new System.Drawing.Point(68, 204);
            this.btnRemoveRole.Name = "btnRemoveRole";
            this.btnRemoveRole.Size = new System.Drawing.Size(199, 72);
            this.btnRemoveRole.TabIndex = 2;
            this.btnRemoveRole.Text = "Makni ulogu organizatora";
            this.btnRemoveRole.UseVisualStyleBackColor = true;
            this.btnRemoveRole.Click += new System.EventHandler(this.btnRemoveRole_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnQuit.Location = new System.Drawing.Point(68, 282);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(199, 72);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Odustani od sakrivanja";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // HideEventFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 430);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemoveRole);
            this.Controls.Add(this.btnHideEvent);
            this.Controls.Add(this.label1);
            this.Name = "HideEventFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HideEventFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHideEvent;
        private System.Windows.Forms.Button btnRemoveRole;
        private System.Windows.Forms.Button btnQuit;
    }
}