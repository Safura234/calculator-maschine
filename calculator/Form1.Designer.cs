namespace calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.TextResult = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiple = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextResult
            // 
            this.TextResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextResult.Location = new System.Drawing.Point(0, 307);
            this.TextResult.Name = "TextResult";
            this.TextResult.Size = new System.Drawing.Size(656, 96);
            this.TextResult.TabIndex = 0;
            this.TextResult.Text = "0";
            this.TextResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.TextResult.Click += new System.EventHandler(this.TextResult_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(0, 813);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(170, 144);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(-10, 404);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(170, 144);
            this.One.TabIndex = 2;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(0, 542);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(170, 144);
            this.Four.TabIndex = 3;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(157, 542);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(170, 144);
            this.Five.TabIndex = 4;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(315, 542);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(170, 144);
            this.Six.TabIndex = 5;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(0, 677);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(170, 144);
            this.Seven.TabIndex = 6;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(157, 404);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(170, 144);
            this.Two.TabIndex = 7;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(157, 677);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(170, 144);
            this.Eight.TabIndex = 8;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.button8_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(323, 677);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(170, 144);
            this.Nine.TabIndex = 9;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(486, 542);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(170, 144);
            this.Minus.TabIndex = 10;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click_1);
            // 
            // Multiple
            // 
            this.Multiple.Location = new System.Drawing.Point(486, 677);
            this.Multiple.Name = "Multiple";
            this.Multiple.Size = new System.Drawing.Size(170, 144);
            this.Multiple.TabIndex = 11;
            this.Multiple.Text = "*";
            this.Multiple.UseVisualStyleBackColor = true;
            this.Multiple.Click += new System.EventHandler(this.Multiple_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(486, 813);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(170, 144);
            this.Divide.TabIndex = 12;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(323, 813);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(170, 144);
            this.Equal.TabIndex = 13;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(157, 813);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(170, 144);
            this.Zero.TabIndex = 14;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(315, 406);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(170, 144);
            this.Three.TabIndex = 15;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(486, 404);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(170, 144);
            this.Sum.TabIndex = 16;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Sum_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 956);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiple);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TextResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TextResult;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiple;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Sum;
    }
}
