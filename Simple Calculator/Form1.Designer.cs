namespace Simple_Calculator
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnMemoryRecall = new System.Windows.Forms.Button();
            this.lblMathFunction = new System.Windows.Forms.Label();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.BackColor = System.Drawing.SystemColors.Window;
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValue.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(13, 13);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(274, 46);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.BackColor = System.Drawing.SystemColors.Window;
            this.lblFirstValue.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstValue.Location = new System.Drawing.Point(16, 13);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(270, 14);
            this.lblFirstValue.TabIndex = 1;
            this.lblFirstValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "←";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(69, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.Location = new System.Drawing.Point(125, 72);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(50, 50);
            this.btnMemory.TabIndex = 4;
            this.btnMemory.Text = "M";
            this.btnMemory.UseVisualStyleBackColor = true;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // btnMemoryRecall
            // 
            this.btnMemoryRecall.Location = new System.Drawing.Point(181, 72);
            this.btnMemoryRecall.Name = "btnMemoryRecall";
            this.btnMemoryRecall.Size = new System.Drawing.Size(50, 50);
            this.btnMemoryRecall.TabIndex = 5;
            this.btnMemoryRecall.Text = "‏MR";
            this.btnMemoryRecall.UseVisualStyleBackColor = true;
            this.btnMemoryRecall.Click += new System.EventHandler(this.btnMemoryRecall_Click);
            // 
            // lblMathFunction
            // 
            this.lblMathFunction.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblMathFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMathFunction.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathFunction.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMathFunction.Location = new System.Drawing.Point(237, 72);
            this.lblMathFunction.Name = "lblMathFunction";
            this.lblMathFunction.Size = new System.Drawing.Size(50, 50);
            this.lblMathFunction.TabIndex = 6;
            this.lblMathFunction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(12, 128);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(50, 50);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "‏7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(69, 128);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(50, 50);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(125, 128);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(50, 50);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(181, 128);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 50);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "∕";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(237, 128);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(50, 50);
            this.btnSign.TabIndex = 12;
            this.btnSign.Text = "±";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(13, 184);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(50, 50);
            this.btnFour.TabIndex = 13;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(69, 184);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(50, 50);
            this.btnFive.TabIndex = 14;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(125, 184);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(50, 50);
            this.btnSix.TabIndex = 15;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(181, 184);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(50, 50);
            this.btnMultiply.TabIndex = 16;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(236, 184);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(50, 50);
            this.btnSqrt.TabIndex = 17;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(13, 240);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(50, 50);
            this.btnOne.TabIndex = 18;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(69, 240);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(50, 50);
            this.btnTwo.TabIndex = 19;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(125, 240);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(50, 50);
            this.btnThree.TabIndex = 20;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(181, 240);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 50);
            this.btnSubtract.TabIndex = 21;
            this.btnSubtract.Text = "−";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(236, 240);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(50, 106);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(13, 296);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(106, 50);
            this.btnZero.TabIndex = 23;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(125, 296);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(50, 50);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(181, 296);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(50, 50);
            this.btnAddition.TabIndex = 25;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 360);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.lblMathFunction);
            this.Controls.Add(this.btnMemoryRecall);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFirstValue);
            this.Controls.Add(this.lblValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnMemoryRecall;
        private System.Windows.Forms.Label lblMathFunction;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnAddition;
    }
}

