namespace Calculator
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
            displayBox = new TextBox();
            btnDiv = new Button();
            btnMult = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnBack = new Button();
            btnNum4 = new Button();
            btnNum5 = new Button();
            btnNum6 = new Button();
            btnClear = new Button();
            btnNum7 = new Button();
            btnNum8 = new Button();
            btnNum9 = new Button();
            btnNum0 = new Button();
            btnPoint = new Button();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // displayBox
            // 
            displayBox.Location = new Point(12, 12);
            displayBox.Multiline = true;
            displayBox.Name = "displayBox";
            displayBox.Size = new Size(154, 23);
            displayBox.TabIndex = 1;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ControlLightLight;
            btnDiv.Location = new Point(132, 41);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(34, 23);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = SystemColors.ControlLightLight;
            btnMult.Location = new Point(92, 41);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(34, 23);
            btnMult.TabIndex = 14;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += btnMult_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = SystemColors.ControlLightLight;
            btnSub.Location = new Point(52, 41);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(34, 23);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseCompatibleTextRendering = true;
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(12, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(34, 23);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnNum1
            // 
            btnNum1.BackColor = SystemColors.ControlLightLight;
            btnNum1.Location = new Point(12, 70);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(34, 23);
            btnNum1.TabIndex = 17;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = false;
            btnNum1.Click += btnNum1_Click;
            // 
            // btnNum2
            // 
            btnNum2.BackColor = SystemColors.ControlLightLight;
            btnNum2.BackgroundImageLayout = ImageLayout.Stretch;
            btnNum2.Location = new Point(52, 70);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(34, 23);
            btnNum2.TabIndex = 18;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = false;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum3
            // 
            btnNum3.Location = new Point(92, 70);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(34, 23);
            btnNum3.TabIndex = 19;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(132, 99);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 23);
            btnBack.TabIndex = 20;
            btnBack.Text = "BA";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNum4
            // 
            btnNum4.Location = new Point(12, 99);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(34, 23);
            btnNum4.TabIndex = 21;
            btnNum4.Text = "4";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum4_Click;
            // 
            // btnNum5
            // 
            btnNum5.Location = new Point(52, 99);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(34, 23);
            btnNum5.TabIndex = 22;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNum5_Click;
            // 
            // btnNum6
            // 
            btnNum6.Location = new Point(92, 99);
            btnNum6.Name = "btnNum6";
            btnNum6.Size = new Size(34, 23);
            btnNum6.TabIndex = 23;
            btnNum6.Text = "6";
            btnNum6.UseVisualStyleBackColor = true;
            btnNum6.Click += btnNum6_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(132, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(34, 23);
            btnClear.TabIndex = 24;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnNum7
            // 
            btnNum7.Location = new Point(12, 128);
            btnNum7.Name = "btnNum7";
            btnNum7.Size = new Size(34, 23);
            btnNum7.TabIndex = 25;
            btnNum7.Text = "7";
            btnNum7.UseVisualStyleBackColor = true;
            btnNum7.Click += btnNum7_Click;
            // 
            // btnNum8
            // 
            btnNum8.Location = new Point(52, 128);
            btnNum8.Name = "btnNum8";
            btnNum8.Size = new Size(34, 23);
            btnNum8.TabIndex = 26;
            btnNum8.Text = "8";
            btnNum8.UseVisualStyleBackColor = true;
            btnNum8.Click += btnNum8_Click;
            // 
            // btnNum9
            // 
            btnNum9.Location = new Point(92, 128);
            btnNum9.Name = "btnNum9";
            btnNum9.Size = new Size(34, 23);
            btnNum9.TabIndex = 27;
            btnNum9.Text = "9";
            btnNum9.UseVisualStyleBackColor = true;
            btnNum9.Click += btnNum9_Click;
            // 
            // btnNum0
            // 
            btnNum0.Location = new Point(12, 157);
            btnNum0.Name = "btnNum0";
            btnNum0.Size = new Size(74, 23);
            btnNum0.TabIndex = 28;
            btnNum0.Text = "0";
            btnNum0.UseVisualStyleBackColor = true;
            btnNum0.Click += btnNum0_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(92, 157);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(34, 23);
            btnPoint.TabIndex = 29;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ControlLightLight;
            btnEqual.Location = new Point(132, 128);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(34, 52);
            btnEqual.TabIndex = 30;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(178, 194);
            Controls.Add(btnEqual);
            Controls.Add(btnPoint);
            Controls.Add(btnNum0);
            Controls.Add(btnNum9);
            Controls.Add(btnNum8);
            Controls.Add(btnNum7);
            Controls.Add(btnClear);
            Controls.Add(btnNum6);
            Controls.Add(btnNum5);
            Controls.Add(btnNum4);
            Controls.Add(btnBack);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMult);
            Controls.Add(btnDiv);
            Controls.Add(displayBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox displayBox;
        private Button btnDiv;
        private Button btnMult;
        private Button btnSub;
        private Button btnAdd;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnBack;
        private Button btnNum4;
        private Button btnNum5;
        private Button btnNum6;
        private Button btnClear;
        private Button btnNum7;
        private Button btnNum8;
        private Button btnNum9;
        private Button btnNum0;
        private Button btnPoint;
        private Button btnEqual;
    }
}