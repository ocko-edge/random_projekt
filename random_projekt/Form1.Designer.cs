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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            nula = new Label();
            label2 = new Label();
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
            calculateButton.Click += calculateButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(178, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 10);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(178, 338);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 36);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(609, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 36);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(396, 338);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 36);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(169, 377);
            label1.Name = "label1";
            label1.Size = new Size(28, 29);
            label1.TabIndex = 5;
            label1.Text = "0";
            // 
            // nula
            // 
            nula.AutoSize = true;
            nula.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nula.Location = new Point(387, 377);
            nula.Name = "nula";
            nula.Size = new Size(28, 29);
            nula.TabIndex = 6;
            nula.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(600, 377);
            label2.Name = "label2";
            label2.Size = new Size(28, 29);
            label2.TabIndex = 7;
            label2.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(nula);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label nula;
        private Label label2;
    }
}
