namespace random_projekt
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
            entryArea = new TextBox();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // entryArea
            // 
            entryArea.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            entryArea.Location = new Point(12, 12);
            entryArea.Name = "entryArea";
            entryArea.Size = new Size(776, 54);
            entryArea.TabIndex = 0;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            calculateButton.Location = new Point(234, 98);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(317, 114);
            calculateButton.TabIndex = 1;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(calculateButton);
            Controls.Add(entryArea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox entryArea;
        private Button calculateButton;
    }
}
