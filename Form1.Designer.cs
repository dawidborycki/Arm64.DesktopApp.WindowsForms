namespace Arm64.DesktopApp.WindowsForms
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
            labelArchitecture = new Label();
            label1 = new Label();
            label2 = new Label();
            numericUpDownMatrixSize = new NumericUpDown();
            numericUpDownExecutionCount = new NumericUpDown();
            buttonStart = new Button();
            listBoxResults = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatrixSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutionCount).BeginInit();
            SuspendLayout();
            // 
            // labelArchitecture
            // 
            labelArchitecture.AutoSize = true;
            labelArchitecture.Location = new Point(12, 9);
            labelArchitecture.Name = "labelArchitecture";
            labelArchitecture.Size = new Size(194, 32);
            labelArchitecture.TabIndex = 0;
            labelArchitecture.Text = "labelArchitecture";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 79);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 1;
            label1.Text = "Matrix size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 147);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 2;
            label2.Text = "Execution count:";
            // 
            // numericUpDownMatrixSize
            // 
            numericUpDownMatrixSize.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownMatrixSize.Location = new Point(260, 72);
            numericUpDownMatrixSize.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownMatrixSize.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownMatrixSize.Name = "numericUpDownMatrixSize";
            numericUpDownMatrixSize.Size = new Size(240, 39);
            numericUpDownMatrixSize.TabIndex = 5;
            numericUpDownMatrixSize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDownExecutionCount
            // 
            numericUpDownExecutionCount.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownExecutionCount.Location = new Point(260, 140);
            numericUpDownExecutionCount.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownExecutionCount.Name = "numericUpDownExecutionCount";
            numericUpDownExecutionCount.Size = new Size(240, 39);
            numericUpDownExecutionCount.TabIndex = 6;
            numericUpDownExecutionCount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 204);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(190, 46);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(12, 272);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(488, 388);
            listBoxResults.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 684);
            Controls.Add(listBoxResults);
            Controls.Add(buttonStart);
            Controls.Add(numericUpDownExecutionCount);
            Controls.Add(numericUpDownMatrixSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelArchitecture);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMatrixSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownExecutionCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelArchitecture;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownMatrixSize;
        private NumericUpDown numericUpDownExecutionCount;
        private Button buttonStart;
        private ListBox listBoxResults;
    }
}
