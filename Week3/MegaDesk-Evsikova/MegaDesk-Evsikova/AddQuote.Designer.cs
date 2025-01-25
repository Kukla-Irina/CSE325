namespace MegaDesk_Evsikova
{
    partial class AddQuote
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
            this.CloseAddQuote = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rushorder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseAddQuote
            // 
            this.CloseAddQuote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseAddQuote.Location = new System.Drawing.Point(701, 821);
            this.CloseAddQuote.Name = "CloseAddQuote";
            this.CloseAddQuote.Size = new System.Drawing.Size(136, 56);
            this.CloseAddQuote.TabIndex = 0;
            this.CloseAddQuote.Text = "Close";
            this.CloseAddQuote.UseVisualStyleBackColor = true;
            this.CloseAddQuote.Click += new System.EventHandler(this.CloseAddQuote_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(344, 266);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(200, 31);
            this.width.TabIndex = 1;
            this.width.TextChanged += new System.EventHandler(this.width_TextChanged);
            this.width.Validating += new System.ComponentModel.CancelEventHandler(this.width_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(257, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(107, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width (24-96 in)";
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(344, 336);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(200, 31);
            this.depth.TabIndex = 4;
            this.depth.TextChanged += new System.EventHandler(this.depth_TextChanged);
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            this.depth.Validating += new System.ComponentModel.CancelEventHandler(this.depth_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(107, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Depth (12-48 in)";
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(344, 196);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(200, 31);
            this.fullname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(107, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Full name";
            // 
            // drawers
            // 
            this.drawers.Location = new System.Drawing.Point(344, 400);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(200, 31);
            this.drawers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(107, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of drawers";
            // 
            // material
            // 
            this.material.Location = new System.Drawing.Point(344, 463);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(200, 31);
            this.material.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(107, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Desktop material";
            // 
            // rushorder
            // 
            this.rushorder.Location = new System.Drawing.Point(344, 530);
            this.rushorder.Name = "rushorder";
            this.rushorder.Size = new System.Drawing.Size(200, 31);
            this.rushorder.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(107, 532);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rush order";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseAddQuote;
            this.ClientSize = new System.Drawing.Size(849, 889);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rushorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.material);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.width);
            this.Controls.Add(this.CloseAddQuote);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseAddQuote;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drawers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox material;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rushorder;
        private System.Windows.Forms.Label label7;
    }
}