
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
            this.display = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn_subtract = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 19);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.display.Size = new System.Drawing.Size(323, 30);
            this.display.TabIndex = 20;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 101);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 40);
            this.btn7.TabIndex = 21;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(211, 101);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(50, 40);
            this.btn_divide.TabIndex = 22;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.Operation);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(78, 101);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 40);
            this.btn8.TabIndex = 23;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 156);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 40);
            this.btn4.TabIndex = 24;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(285, 101);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(50, 40);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "CE";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(78, 156);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 40);
            this.btn5.TabIndex = 26;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(211, 156);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(50, 40);
            this.btn_multiply.TabIndex = 27;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.Operation);
            // 
            // btn_clearall
            // 
            this.btn_clearall.Location = new System.Drawing.Point(285, 156);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(50, 40);
            this.btn_clearall.TabIndex = 28;
            this.btn_clearall.Text = "C";
            this.btn_clearall.UseVisualStyleBackColor = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 212);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 40);
            this.btn1.TabIndex = 29;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(78, 212);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 40);
            this.btn2.TabIndex = 30;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(145, 212);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 40);
            this.btn3.TabIndex = 31;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 271);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(116, 40);
            this.btn0.TabIndex = 32;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(145, 271);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(50, 40);
            this.btn_dot.TabIndex = 33;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn_equals
            // 
            this.btn_equals.Location = new System.Drawing.Point(285, 212);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(50, 99);
            this.btn_equals.TabIndex = 34;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(145, 101);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 40);
            this.btn9.TabIndex = 35;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(145, 156);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 40);
            this.btn6.TabIndex = 36;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Pressed_Button);
            // 
            // btn_subtract
            // 
            this.btn_subtract.Location = new System.Drawing.Point(211, 212);
            this.btn_subtract.Name = "btn_subtract";
            this.btn_subtract.Size = new System.Drawing.Size(50, 40);
            this.btn_subtract.TabIndex = 37;
            this.btn_subtract.Text = "-";
            this.btn_subtract.UseVisualStyleBackColor = true;
            this.btn_subtract.Click += new System.EventHandler(this.Operation);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(211, 271);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(50, 40);
            this.btn_sum.TabIndex = 38;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.Operation);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sum);
            this.panel1.Controls.Add(this.btn_subtract);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn_equals);
            this.panel1.Controls.Add(this.btn_dot);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn_clearall);
            this.panel1.Controls.Add(this.btn_multiply);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn_divide);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.display);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 347);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 362);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Panel panel1;
    }
}

