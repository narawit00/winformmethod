namespace winformmethod
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            btnBMI = new Button();
            lblResult = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumOrchid;
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(272, 79);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "โปรเเกรมคำนวนณค่า BMI ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumSlateBlue;
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(98, 257);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "ส่วนสุง(cm)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumSlateBlue;
            label3.ForeColor = Color.White;
            label3.Location = new Point(98, 313);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "น้ำหนัก(kg)";
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.Violet;
            txtWeight.Location = new Point(210, 310);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 4;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.Violet;
            txtHeight.Location = new Point(210, 257);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumSlateBlue;
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(143, 208);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 5;
            label4.Text = "อายุ";
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.Violet;
            txtAge.Location = new Point(210, 208);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSlateBlue;
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(94, 151);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 7;
            label5.Text = "ชื่อ-นามสกุล";
            // 
            // txtName
            // 
            txtName.BackColor = Color.Violet;
            txtName.Location = new Point(210, 151);
            txtName.Name = "txtName";
            txtName.Size = new Size(281, 27);
            txtName.TabIndex = 1;
            // 
            // btnBMI
            // 
            btnBMI.BackColor = Color.Violet;
            btnBMI.ForeColor = SystemColors.ButtonHighlight;
            btnBMI.Location = new Point(353, 206);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(113, 76);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่า BMI..";
            btnBMI.UseVisualStyleBackColor = false;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.DarkOrchid;
            lblResult.ForeColor = SystemColors.ButtonHighlight;
            lblResult.Location = new Point(497, 151);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(277, 186);
            lblResult.TabIndex = 10;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.MediumOrchid;
            btnClear.Location = new Point(341, 308);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 29);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear here";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnBMI);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtHeight);
            Controls.Add(txtWeight);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BMI PROGRAM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtName;
        private Button btnBMI;
        private Label lblResult;
        private Button btnClear;
    }
}
