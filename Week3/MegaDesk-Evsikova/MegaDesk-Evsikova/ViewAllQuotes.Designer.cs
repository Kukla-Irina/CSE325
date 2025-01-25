namespace MegaDesk_Evsikova
{
    partial class ViewAllQuotes
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
            this.CloseViewAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseViewAllQuotes
            // 
            this.CloseViewAllQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseViewAllQuotes.Location = new System.Drawing.Point(701, 821);
            this.CloseViewAllQuotes.Name = "CloseViewAllQuotes";
            this.CloseViewAllQuotes.Size = new System.Drawing.Size(136, 56);
            this.CloseViewAllQuotes.TabIndex = 2;
            this.CloseViewAllQuotes.Text = "Close";
            this.CloseViewAllQuotes.UseVisualStyleBackColor = true;
            this.CloseViewAllQuotes.Click += new System.EventHandler(this.CloseViewAllQuotes_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 889);
            this.Controls.Add(this.CloseViewAllQuotes);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseViewAllQuotes;
    }
}