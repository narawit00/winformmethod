namespace winformmethod
{
    partial class Form3
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
            frmBMI = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // frmBMI
            // 
            frmBMI.Location = new Point(265, 47);
            frmBMI.Name = "frmBMI";
            frmBMI.Size = new Size(94, 29);
            frmBMI.TabIndex = 0;
            frmBMI.Text = "ฟรอม Bmi";
            frmBMI.UseVisualStyleBackColor = true;
            frmBMI.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(265, 127);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(frmBMI);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button frmBMI;
        private Button button2;
    }
}