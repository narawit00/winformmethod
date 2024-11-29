namespace winformmethod
{
    partial class Form2
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
            button1 = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(374, 411);
            button1.Name = "button1";
            button1.Size = new Size(94, 30);
            button1.TabIndex = 1;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.Coral;
            txtResult.Location = new Point(285, 51);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(264, 339);
            txtResult.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(832, 492);
            Controls.Add(txtResult);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtResult;
    }
}