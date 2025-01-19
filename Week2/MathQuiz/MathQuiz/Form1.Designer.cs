namespace MathQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            label2 = new Label();
            plusRightLabel = new Label();
            label4 = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            label3 = new Label();
            minusRightLabel = new Label();
            label6 = new Label();
            minusLeftLabel = new Label();
            product = new NumericUpDown();
            label8 = new Label();
            timesRightLabel = new Label();
            label10 = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            label12 = new Label();
            dividedRightLabel = new Label();
            label14 = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(689, 18);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(298, 60);
            timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(487, 21);
            label1.Name = "label1";
            label1.Size = new Size(196, 57);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Font = new Font("Segoe UI", 18F);
            plusLeftLabel.Location = new Point(125, 152);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(114, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(552, 152);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 3;
            label2.Text = "=";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Font = new Font("Segoe UI", 18F);
            plusRightLabel.Location = new Point(423, 152);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(123, 50);
            plusRightLabel.TabIndex = 4;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(299, 152);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 5;
            label4.Text = "+";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(647, 152);
            sum.Name = "sum";
            sum.Size = new Size(130, 71);
            sum.TabIndex = 1;
            sum.Enter += answer_Enter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(647, 286);
            difference.Name = "difference";
            difference.Size = new Size(130, 71);
            difference.TabIndex = 2;
            difference.Enter += answer_Enter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(299, 286);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 10;
            label3.Text = "-";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Font = new Font("Segoe UI", 18F);
            minusRightLabel.Location = new Point(423, 286);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(123, 50);
            minusRightLabel.TabIndex = 9;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(552, 286);
            label6.Name = "label6";
            label6.Size = new Size(60, 50);
            label6.TabIndex = 8;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Font = new Font("Segoe UI", 18F);
            minusLeftLabel.Location = new Point(125, 286);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(114, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(647, 425);
            product.Name = "product";
            product.Size = new Size(130, 71);
            product.TabIndex = 3;
            product.Enter += answer_Enter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 18F);
            label8.Location = new Point(299, 425);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 15;
            label8.Text = "×";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Font = new Font("Segoe UI", 18F);
            timesRightLabel.Location = new Point(423, 425);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(123, 50);
            timesRightLabel.TabIndex = 14;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 18F);
            label10.Location = new Point(552, 425);
            label10.Name = "label10";
            label10.Size = new Size(60, 50);
            label10.TabIndex = 13;
            label10.Text = "=";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Font = new Font("Segoe UI", 18F);
            timesLeftLabel.Location = new Point(125, 425);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(114, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(647, 560);
            quotient.Name = "quotient";
            quotient.Size = new Size(130, 71);
            quotient.TabIndex = 4;
            quotient.Enter += answer_Enter;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 18F);
            label12.Location = new Point(299, 560);
            label12.Name = "label12";
            label12.Size = new Size(60, 50);
            label12.TabIndex = 20;
            label12.Text = "÷";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Font = new Font("Segoe UI", 18F);
            dividedRightLabel.Location = new Point(423, 560);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(123, 50);
            dividedRightLabel.TabIndex = 19;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(552, 560);
            label14.Name = "label14";
            label14.Size = new Size(60, 50);
            label14.TabIndex = 18;
            label14.Text = "=";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Font = new Font("Segoe UI", 18F);
            dividedLeftLabel.Location = new Point(125, 560);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(114, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F);
            startButton.Location = new Point(369, 693);
            startButton.Name = "startButton";
            startButton.Size = new Size(254, 61);
            startButton.TabIndex = 0;
            startButton.Text = "Start the quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 39);
            dateTimePicker1.TabIndex = 21;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 815);
            Controls.Add(dateTimePicker1);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(label12);
            Controls.Add(dividedRightLabel);
            Controls.Add(label14);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(label8);
            Controls.Add(timesRightLabel);
            Controls.Add(label10);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(label3);
            Controls.Add(minusRightLabel);
            Controls.Add(label6);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(plusRightLabel);
            Controls.Add(label2);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            Text = "Irina Evsikova Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label label2;
        private Label plusRightLabel;
        private Label label4;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label3;
        private Label minusRightLabel;
        private Label label6;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label label8;
        private Label timesRightLabel;
        private Label label10;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label label12;
        private Label dividedRightLabel;
        private Label label14;
        private Label dividedLeftLabel;
        private Button startButton;
        private DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
    }
}
