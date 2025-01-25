namespace MegaDesk_Evsikova
{
    partial class SearchQuotes
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
            this.CloseSearchQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseSearchQuotes
            // 
            this.CloseSearchQuotes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseSearchQuotes.Location = new System.Drawing.Point(701, 821);
            this.CloseSearchQuotes.Name = "CloseSearchQuotes";
            this.CloseSearchQuotes.Size = new System.Drawing.Size(136, 56);
            this.CloseSearchQuotes.TabIndex = 2;
            this.CloseSearchQuotes.Text = "Close";
            this.CloseSearchQuotes.UseVisualStyleBackColor = true;
            this.CloseSearchQuotes.Click += new System.EventHandler(this.CloseSearchQuotes_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 889);
            this.Controls.Add(this.CloseSearchQuotes);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseSearchQuotes;
    }
}