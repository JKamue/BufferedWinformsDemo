namespace DoubleBufferedDemo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlUnbuffered = new System.Windows.Forms.Panel();
            this.pnlBuffered = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlUnbuffered);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlBuffered);
            this.splitContainer1.Size = new System.Drawing.Size(782, 353);
            this.splitContainer1.SplitterDistance = 391;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlUnbuffered
            // 
            this.pnlUnbuffered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUnbuffered.Location = new System.Drawing.Point(0, 0);
            this.pnlUnbuffered.Name = "pnlUnbuffered";
            this.pnlUnbuffered.Size = new System.Drawing.Size(389, 351);
            this.pnlUnbuffered.TabIndex = 0;
            this.pnlUnbuffered.Click += new System.EventHandler(this.panel_Click);
            // 
            // pnlBuffered
            // 
            this.pnlBuffered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBuffered.Location = new System.Drawing.Point(0, 0);
            this.pnlBuffered.Name = "pnlBuffered";
            this.pnlBuffered.Size = new System.Drawing.Size(385, 351);
            this.pnlBuffered.TabIndex = 0;
            this.pnlBuffered.Click += new System.EventHandler(this.panel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.splitContainer1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unbuffered vs. Buffered panels";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlUnbuffered;
        private System.Windows.Forms.Panel pnlBuffered;
    }
}

