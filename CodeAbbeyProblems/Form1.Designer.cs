namespace CodeAbbeyProblems
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
            this.textBoxInputOne = new System.Windows.Forms.TextBox();
            this.textBoxInputTwo = new System.Windows.Forms.TextBox();
            this.buttonExecuteProblem = new System.Windows.Forms.Button();
            this.textBoxOutputOne = new System.Windows.Forms.TextBox();
            this.numericUpDownProblemSelection = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProblemSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInputOne
            // 
            this.textBoxInputOne.Location = new System.Drawing.Point(39, 106);
            this.textBoxInputOne.Multiline = true;
            this.textBoxInputOne.Name = "textBoxInputOne";
            this.textBoxInputOne.Size = new System.Drawing.Size(100, 78);
            this.textBoxInputOne.TabIndex = 0;
            this.textBoxInputOne.Text = "Input One";
            // 
            // textBoxInputTwo
            // 
            this.textBoxInputTwo.Location = new System.Drawing.Point(39, 238);
            this.textBoxInputTwo.Multiline = true;
            this.textBoxInputTwo.Name = "textBoxInputTwo";
            this.textBoxInputTwo.Size = new System.Drawing.Size(120, 126);
            this.textBoxInputTwo.TabIndex = 1;
            this.textBoxInputTwo.Text = "Input Two";
            // 
            // buttonExecuteProblem
            // 
            this.buttonExecuteProblem.Location = new System.Drawing.Point(441, 154);
            this.buttonExecuteProblem.Name = "buttonExecuteProblem";
            this.buttonExecuteProblem.Size = new System.Drawing.Size(72, 30);
            this.buttonExecuteProblem.TabIndex = 2;
            this.buttonExecuteProblem.Text = "Execute";
            this.buttonExecuteProblem.UseVisualStyleBackColor = true;
            this.buttonExecuteProblem.Click += new System.EventHandler(this.buttonProblemOne_Click);
            // 
            // textBoxOutputOne
            // 
            this.textBoxOutputOne.Location = new System.Drawing.Point(216, 106);
            this.textBoxOutputOne.Multiline = true;
            this.textBoxOutputOne.Name = "textBoxOutputOne";
            this.textBoxOutputOne.Size = new System.Drawing.Size(167, 102);
            this.textBoxOutputOne.TabIndex = 3;
            this.textBoxOutputOne.Text = "Output One";
            // 
            // numericUpDownProblemSelection
            // 
            this.numericUpDownProblemSelection.Location = new System.Drawing.Point(441, 106);
            this.numericUpDownProblemSelection.Name = "numericUpDownProblemSelection";
            this.numericUpDownProblemSelection.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownProblemSelection.TabIndex = 4;
            this.numericUpDownProblemSelection.ValueChanged += new System.EventHandler(this.numericUpDownProblemSelection_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 579);
            this.Controls.Add(this.numericUpDownProblemSelection);
            this.Controls.Add(this.textBoxOutputOne);
            this.Controls.Add(this.buttonExecuteProblem);
            this.Controls.Add(this.textBoxInputTwo);
            this.Controls.Add(this.textBoxInputOne);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProblemSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputOne;
        private System.Windows.Forms.TextBox textBoxInputTwo;
        private System.Windows.Forms.Button buttonExecuteProblem;
        private System.Windows.Forms.TextBox textBoxOutputOne;
        private System.Windows.Forms.NumericUpDown numericUpDownProblemSelection;
    }
}

