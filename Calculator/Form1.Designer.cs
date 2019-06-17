namespace Calculator
{
    partial class Form1
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
            this.numberHolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnNumber = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.toolBar = new System.Windows.Forms.Panel();
            this.txtStored = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberHolder
            // 
            this.numberHolder.BackColor = System.Drawing.Color.Crimson;
            this.numberHolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberHolder.ForeColor = System.Drawing.Color.White;
            this.numberHolder.Location = new System.Drawing.Point(25, 40);
            this.numberHolder.MaximumSize = new System.Drawing.Size(275, 50);
            this.numberHolder.MinimumSize = new System.Drawing.Size(275, 50);
            this.numberHolder.Name = "numberHolder";
            this.numberHolder.Size = new System.Drawing.Size(275, 51);
            this.numberHolder.TabIndex = 50;
            this.numberHolder.Text = "0";
            this.numberHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberHolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberHolder_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(125, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(225, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(225, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(125, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(25, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Crimson;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(225, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "C";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.Color.Crimson;
            this.btnDecimal.FlatAppearance.BorderSize = 0;
            this.btnDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecimal.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.ForeColor = System.Drawing.Color.White;
            this.btnDecimal.Location = new System.Drawing.Point(125, 295);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(75, 30);
            this.btnDecimal.TabIndex = 11;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnNumber
            // 
            this.btnNumber.BackColor = System.Drawing.Color.Crimson;
            this.btnNumber.FlatAppearance.BorderSize = 0;
            this.btnNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumber.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber.ForeColor = System.Drawing.Color.White;
            this.btnNumber.Location = new System.Drawing.Point(25, 295);
            this.btnNumber.Name = "btnNumber";
            this.btnNumber.Size = new System.Drawing.Size(75, 30);
            this.btnNumber.TabIndex = 10;
            this.btnNumber.Text = "0";
            this.btnNumber.UseVisualStyleBackColor = false;
            this.btnNumber.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Crimson;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(225, 240);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 30);
            this.button10.TabIndex = 9;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Crimson;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(125, 240);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 30);
            this.button11.TabIndex = 8;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Crimson;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(25, 240);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 30);
            this.button12.TabIndex = 7;
            this.button12.Text = "1";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Crimson;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(125, 350);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 30);
            this.button13.TabIndex = 14;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Crimson;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(25, 350);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 30);
            this.button14.TabIndex = 13;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Crimson;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(225, 350);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(75, 82);
            this.btnEquals.TabIndex = 17;
            this.btnEquals.Text = "Enter";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Crimson;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(125, 402);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 30);
            this.button16.TabIndex = 16;
            this.button16.Text = "/";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Crimson;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(25, 402);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 30);
            this.button17.TabIndex = 15;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // toolBar
            // 
            this.toolBar.Controls.Add(this.btnExit);
            this.toolBar.Controls.Add(this.txtStored);
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(324, 34);
            this.toolBar.TabIndex = 18;
            this.toolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolBar_MouseDown);
            this.toolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolBar_MouseMove);
            this.toolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolBar_MouseUp);
            // 
            // txtStored
            // 
            this.txtStored.AutoSize = true;
            this.txtStored.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStored.ForeColor = System.Drawing.Color.Crimson;
            this.txtStored.Location = new System.Drawing.Point(3, 9);
            this.txtStored.Name = "txtStored";
            this.txtStored.Size = new System.Drawing.Size(0, 20);
            this.txtStored.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Mistral", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(303, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 22);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(325, 460);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNumber);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberHolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberHolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnNumber;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.Label txtStored;
        private System.Windows.Forms.Label btnExit;
    }
}

