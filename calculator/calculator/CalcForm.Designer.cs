namespace calculator
{
    partial class CalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.gradient1 = new calculator.Gradient();
            this.decButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.buttonMD = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonMS = new System.Windows.Forms.Button();
            this.buttonMC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundButton1 = new calculator.RoundButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 60F;
            this.gradient1.BackColor = System.Drawing.Color.Transparent;
            this.gradient1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.decButton);
            this.gradient1.Controls.Add(this.button0);
            this.gradient1.Controls.Add(this.clearButton);
            this.gradient1.Controls.Add(this.buttonMD);
            this.gradient1.Controls.Add(this.buttonMin);
            this.gradient1.Controls.Add(this.buttonPlus);
            this.gradient1.Controls.Add(this.buttonDiv);
            this.gradient1.Controls.Add(this.buttonMul);
            this.gradient1.Controls.Add(this.buttonMS);
            this.gradient1.Controls.Add(this.buttonMC);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.pictureBox1);
            this.gradient1.Controls.Add(this.textBox1);
            this.gradient1.Controls.Add(this.roundButton1);
            this.gradient1.Controls.Add(this.button3);
            this.gradient1.Controls.Add(this.button6);
            this.gradient1.Controls.Add(this.button9);
            this.gradient1.Controls.Add(this.button2);
            this.gradient1.Controls.Add(this.button5);
            this.gradient1.Controls.Add(this.button8);
            this.gradient1.Controls.Add(this.button1);
            this.gradient1.Controls.Add(this.button4);
            this.gradient1.Controls.Add(this.button7);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gradient1.ForeColor = System.Drawing.Color.White;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(470, 590);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.CornflowerBlue;
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);
            // 
            // decButton
            // 
            this.decButton.BackColor = System.Drawing.Color.Transparent;
            this.decButton.FlatAppearance.BorderSize = 0;
            this.decButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decButton.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.decButton.ForeColor = System.Drawing.Color.White;
            this.decButton.Location = new System.Drawing.Point(32, 517);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(64, 67);
            this.decButton.TabIndex = 5;
            this.decButton.Text = ".";
            this.decButton.UseVisualStyleBackColor = false;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Transparent;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(106, 519);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(64, 67);
            this.button0.TabIndex = 5;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(297, 243);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(133, 47);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // buttonMD
            // 
            this.buttonMD.FlatAppearance.BorderSize = 0;
            this.buttonMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMD.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMD.Location = new System.Drawing.Point(205, 243);
            this.buttonMD.Name = "buttonMD";
            this.buttonMD.Size = new System.Drawing.Size(49, 47);
            this.buttonMD.TabIndex = 27;
            this.buttonMD.Text = "MD";
            this.buttonMD.UseVisualStyleBackColor = true;
            this.buttonMD.Click += new System.EventHandler(this.buttonMD_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMin.Location = new System.Drawing.Point(366, 309);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(64, 67);
            this.buttonMin.TabIndex = 26;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI Emoji", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(297, 309);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(64, 80);
            this.buttonPlus.TabIndex = 25;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.FlatAppearance.BorderSize = 0;
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Location = new System.Drawing.Point(366, 408);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(64, 67);
            this.buttonDiv.TabIndex = 24;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.FlatAppearance.BorderSize = 0;
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul.Location = new System.Drawing.Point(296, 408);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(64, 67);
            this.buttonMul.TabIndex = 23;
            this.buttonMul.Text = "X";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.buttonMul_Click);
            // 
            // buttonMS
            // 
            this.buttonMS.FlatAppearance.BorderSize = 0;
            this.buttonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMS.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMS.ForeColor = System.Drawing.Color.White;
            this.buttonMS.Location = new System.Drawing.Point(121, 243);
            this.buttonMS.Name = "buttonMS";
            this.buttonMS.Size = new System.Drawing.Size(49, 47);
            this.buttonMS.TabIndex = 22;
            this.buttonMS.Text = "MS";
            this.buttonMS.UseVisualStyleBackColor = true;
            this.buttonMS.Click += new System.EventHandler(this.buttonMS_Click);
            // 
            // buttonMC
            // 
            this.buttonMC.FlatAppearance.BorderSize = 0;
            this.buttonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMC.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMC.Location = new System.Drawing.Point(32, 243);
            this.buttonMC.Name = "buttonMC";
            this.buttonMC.Size = new System.Drawing.Size(49, 47);
            this.buttonMC.TabIndex = 18;
            this.buttonMC.Text = "MC";
            this.buttonMC.UseVisualStyleBackColor = true;
            this.buttonMC.Click += new System.EventHandler(this.buttonMC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Roses Inc.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(32, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "0";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(398, 168);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderColor = System.Drawing.Color.White;
            this.roundButton1.ButtonColor = System.Drawing.Color.White;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundButton1.Location = new System.Drawing.Point(297, 519);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundButton1.OnHoverButtonColor = System.Drawing.SystemColors.Highlight;
            this.roundButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundButton1.Size = new System.Drawing.Size(133, 54);
            this.roundButton1.TabIndex = 10;
            this.roundButton1.Text = "=";
            this.roundButton1.TextColor = System.Drawing.Color.DarkGray;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(190, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 67);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(190, 369);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 67);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(190, 296);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 67);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(106, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 67);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(106, 369);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(106, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 67);
            this.button8.TabIndex = 3;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(22, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(22, 369);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 67);
            this.button4.TabIndex = 1;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(22, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 67);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(470, 590);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private RoundButton roundButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMC;
        private System.Windows.Forms.Button buttonMD;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonMS;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button decButton;
    }
}

