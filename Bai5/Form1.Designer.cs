namespace Bai5
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
        private void InitializeComponent() {
            label1 = new Label();
            num1 = new TextBox();
            label2 = new Label();
            num2 = new TextBox();
            plus = new Button();
            divide = new Button();
            multiply = new Button();
            minus = new Button();
            label3 = new Label();
            answer = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 59);
            label1.TabIndex = 0;
            label1.Text = "num1";
           
            // 
            // num1
            // 
            num1.Location = new Point(278, 44);
            num1.Margin = new Padding(6);
            num1.Name = "num1";
            num1.Size = new Size(648, 65);
            num1.TabIndex = 1;
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 175);
            label2.Name = "label2";
            label2.Size = new Size(133, 59);
            label2.TabIndex = 2;
            label2.Text = "num2";
            // 
            // num2
            // 
            num2.Location = new Point(278, 175);
            num2.Margin = new Padding(6);
            num2.Name = "num2";
            num2.Size = new Size(648, 65);
            num2.TabIndex = 3;
            // 
            // plus
            // 
            plus.Location = new Point(114, 294);
            plus.Name = "plus";
            plus.Size = new Size(106, 93);
            plus.TabIndex = 4;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            divide.Location = new Point(627, 294);
            divide.Name = "divide";
            divide.Size = new Size(106, 93);
            divide.TabIndex = 5;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            multiply.Location = new Point(450, 294);
            multiply.Name = "multiply";
            multiply.Size = new Size(106, 93);
            multiply.TabIndex = 6;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Location = new Point(278, 294);
            minus.Name = "minus";
            minus.Size = new Size(106, 93);
            minus.TabIndex = 7;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 465);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(184, 59);
            label3.TabIndex = 8;
            label3.Text = "Answer: ";
          
            // 
            // answer
            // 
            answer.Location = new Point(310, 462);
            answer.Margin = new Padding(6);
            answer.Name = "answer";
            answer.Size = new Size(648, 65);
            answer.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(24F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 747);
            Controls.Add(answer);
            Controls.Add(label3);
            Controls.Add(minus);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(plus);
            Controls.Add(num2);
            Controls.Add(label2);
            Controls.Add(num1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1;
        private Label label2;
        private TextBox num2;
        private Button plus;
        private Button divide;
        private Button multiply;
        private Button minus;
        private Label label3;
        private TextBox answer;
    }
}
