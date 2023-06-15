namespace test
{
    partial class TestForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton answerRadioButton1;
        private System.Windows.Forms.RadioButton answerRadioButton2;
        private System.Windows.Forms.RadioButton answerRadioButton3;

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.okButton = new System.Windows.Forms.Button();
            this.answerRadioButton1 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton2 = new System.Windows.Forms.RadioButton();
            this.answerRadioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(38, 56);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 13);
            this.questionLabel.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(50, 19);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(187, 13);
            this.progressBar.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(155, 184);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(41, 32);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // answerRadioButton1
            // 
            this.answerRadioButton1.AutoSize = true;
            this.answerRadioButton1.Location = new System.Drawing.Point(41, 86);
            this.answerRadioButton1.Name = "answerRadioButton1";
            this.answerRadioButton1.Size = new System.Drawing.Size(14, 13);
            this.answerRadioButton1.TabIndex = 4;
            this.answerRadioButton1.TabStop = true;
            this.answerRadioButton1.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton2
            // 
            this.answerRadioButton2.AutoSize = true;
            this.answerRadioButton2.Location = new System.Drawing.Point(41, 109);
            this.answerRadioButton2.Name = "answerRadioButton2";
            this.answerRadioButton2.Size = new System.Drawing.Size(14, 13);
            this.answerRadioButton2.TabIndex = 4;
            this.answerRadioButton2.TabStop = true;
            this.answerRadioButton2.UseVisualStyleBackColor = true;
            // 
            // answerRadioButton3
            // 
            this.answerRadioButton3.AutoSize = true;
            this.answerRadioButton3.Location = new System.Drawing.Point(41, 132);
            this.answerRadioButton3.Name = "answerRadioButton3";
            this.answerRadioButton3.Size = new System.Drawing.Size(14, 13);
            this.answerRadioButton3.TabIndex = 4;
            this.answerRadioButton3.TabStop = true;
            this.answerRadioButton3.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.ClientSize = new System.Drawing.Size(292, 261);
            this.Controls.Add(this.answerRadioButton3);
            this.Controls.Add(this.answerRadioButton2);
            this.Controls.Add(this.answerRadioButton1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.questionLabel);
            this.Name = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
