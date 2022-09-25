namespace System
{
    partial class NameEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameEdit));
            this.tbEditLN = new System.Windows.Forms.TextBox();
            this.tbEditMI = new System.Windows.Forms.TextBox();
            this.tbEditFN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbEditLN
            // 
            this.tbEditLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbEditLN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbEditLN.ForeColor = System.Drawing.Color.White;
            this.tbEditLN.Location = new System.Drawing.Point(43, 130);
            this.tbEditLN.Name = "tbEditLN";
            this.tbEditLN.Size = new System.Drawing.Size(485, 29);
            this.tbEditLN.TabIndex = 5;
            this.tbEditLN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEditLN_KeyDown);
            // 
            // tbEditMI
            // 
            this.tbEditMI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbEditMI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbEditMI.ForeColor = System.Drawing.Color.White;
            this.tbEditMI.Location = new System.Drawing.Point(43, 75);
            this.tbEditMI.Name = "tbEditMI";
            this.tbEditMI.Size = new System.Drawing.Size(485, 29);
            this.tbEditMI.TabIndex = 4;
            this.tbEditMI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEditMI_KeyDown);
            // 
            // tbEditFN
            // 
            this.tbEditFN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.tbEditFN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.tbEditFN.ForeColor = System.Drawing.Color.White;
            this.tbEditFN.Location = new System.Drawing.Point(43, 20);
            this.tbEditFN.Name = "tbEditFN";
            this.tbEditFN.Size = new System.Drawing.Size(485, 29);
            this.tbEditFN.TabIndex = 3;
            this.tbEditFN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEditFN_KeyDown);
            // 
            // NameEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::System.Properties.Resources.BG21;
            this.ClientSize = new System.Drawing.Size(570, 180);
            this.Controls.Add(this.tbEditLN);
            this.Controls.Add(this.tbEditMI);
            this.Controls.Add(this.tbEditFN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NameEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NameEdit";
            this.Load += new System.EventHandler(this.NameEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.TextBox tbEditLN;
        private Windows.Forms.TextBox tbEditMI;
        private Windows.Forms.TextBox tbEditFN;
    }
}