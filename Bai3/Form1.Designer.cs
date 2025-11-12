namespace Bai1
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
            toggle_btn = new Button();
            SuspendLayout();
            // 
            // toggle_btn
            // 
            toggle_btn.BackColor = SystemColors.Info;
            toggle_btn.ForeColor = SystemColors.ActiveCaption;
            toggle_btn.Location = new Point(420, 303);
            toggle_btn.Name = "toggle_btn";
            toggle_btn.Size = new Size(313, 85);
            toggle_btn.TabIndex = 0;
            toggle_btn.Text = "change color";
            toggle_btn.UseVisualStyleBackColor = false;
            toggle_btn.Click += Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(25F, 59F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 751);
            Controls.Add(toggle_btn);
            Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HotTrack;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button toggle_btn;
    }
}
