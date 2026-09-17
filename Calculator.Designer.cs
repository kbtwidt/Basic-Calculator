namespace Week4Assignment4._1._2
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
            btn9 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnEnter = new Button();
            txtDisplay = new TextBox();
            btnClear = new Button();
            btnDecimal = new Button();
            btnPlusMinus = new Button();
            SuspendLayout();
            // 
            // btn9
            // 
            btn9.Location = new Point(225, 325);
            btn9.Name = "btn9";
            btn9.Size = new Size(62, 51);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += numberButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(225, 175);
            btn3.Name = "btn3";
            btn3.Size = new Size(62, 51);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += numberButton_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(45, 250);
            btn4.Name = "btn4";
            btn4.Size = new Size(62, 51);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += numberButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(135, 250);
            btn5.Name = "btn5";
            btn5.Size = new Size(62, 51);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += numberButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(225, 250);
            btn6.Name = "btn6";
            btn6.Size = new Size(62, 51);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += numberButton_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(45, 325);
            btn7.Name = "btn7";
            btn7.Size = new Size(62, 51);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += numberButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(135, 325);
            btn8.Name = "btn8";
            btn8.Size = new Size(62, 51);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += numberButton_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(45, 175);
            btn1.Name = "btn1";
            btn1.Size = new Size(62, 51);
            btn1.TabIndex = 15;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += numberButton_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(135, 175);
            btn2.Name = "btn2";
            btn2.Size = new Size(62, 51);
            btn2.TabIndex = 16;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += numberButton_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(135, 400);
            btn0.Name = "btn0";
            btn0.Size = new Size(62, 51);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += numberButton_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Yellow;
            btnAdd.Location = new Point(335, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(62, 51);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += operationButton_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Yellow;
            btnSubtract.Location = new Point(335, 250);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(62, 51);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += operationButton_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Yellow;
            btnDivide.Location = new Point(335, 325);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(62, 51);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += operationButton_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Yellow;
            btnMultiply.Location = new Point(335, 400);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(62, 51);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += operationButton_Click;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Orange;
            btnEnter.Location = new Point(275, 475);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(122, 51);
            btnEnter.TabIndex = 15;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.Black;
            txtDisplay.Font = new Font("Segoe UI", 20F);
            txtDisplay.ForeColor = Color.Lime;
            txtDisplay.Location = new Point(12, 50);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(398, 61);
            txtDisplay.TabIndex = 16;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Location = new Point(135, 475);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 51);
            btnClear.TabIndex = 17;
            btnClear.Text = "C/CE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Location = new Point(225, 400);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(62, 51);
            btnDecimal.TabIndex = 18;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += numberButton_Click;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Location = new Point(45, 400);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(62, 51);
            btnPlusMinus.TabIndex = 19;
            btnPlusMinus.Text = "+/-";
            btnPlusMinus.UseVisualStyleBackColor = true;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(422, 560);
            Controls.Add(btnPlusMinus);
            Controls.Add(btnDecimal);
            Controls.Add(btnClear);
            Controls.Add(txtDisplay);
            Controls.Add(btnEnter);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn9);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn9;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn1;
        private Button btn2;
        private Button btn0;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnEnter;
        private TextBox txtDisplay;
        private Button btnClear;
        private Button btnDecimal;
        private Button btnPlusMinus;
    }
}
