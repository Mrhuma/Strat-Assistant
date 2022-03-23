namespace Strat_Assistant
{
    partial class WaitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitForm));
            this.WaitMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WaitMessage
            // 
            this.WaitMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.WaitMessage.ForeColor = System.Drawing.Color.White;
            this.WaitMessage.Location = new System.Drawing.Point(12, 12);
            this.WaitMessage.Multiline = true;
            this.WaitMessage.Name = "WaitMessage";
            this.WaitMessage.ReadOnly = true;
            this.WaitMessage.ShortcutsEnabled = false;
            this.WaitMessage.Size = new System.Drawing.Size(260, 49);
            this.WaitMessage.TabIndex = 0;
            this.WaitMessage.TabStop = false;
            this.WaitMessage.Text = "Uploading images to Imgur, please wait until this window disappears.";
            this.WaitMessage.UseWaitCursor = true;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(284, 152);
            this.Controls.Add(this.WaitMessage);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaitForm";
            this.Text = "Loading...";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WaitMessage;
    }
}