namespace MegaDesk_Evsikova
{
    partial class DisplayQuote
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
            this.CloseDisplayQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseDisplayQuote
            // 
            this.CloseDisplayQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseDisplayQuote.Location = new System.Drawing.Point(701, 821);
            this.CloseDisplayQuote.Name = "CloseDisplayQuote";
            this.CloseDisplayQuote.Size = new System.Drawing.Size(136, 56);
            this.CloseDisplayQuote.TabIndex = 1;
            this.CloseDisplayQuote.Text = "Close";
            this.CloseDisplayQuote.UseVisualStyleBackColor = true;
            this.CloseDisplayQuote.Click += new System.EventHandler(this.CloseDisplayQuote_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 889);
            this.Controls.Add(this.CloseDisplayQuote);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseDisplayQuote;
    }
}