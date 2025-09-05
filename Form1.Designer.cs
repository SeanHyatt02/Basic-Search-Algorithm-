namespace HyattSearching {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.groupBoxFunctions = new System.Windows.Forms.GroupBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonFileUpload = new System.Windows.Forms.Button();
            this.buttonSequential = new System.Windows.Forms.Button();
            this.buttonBinary = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(402, 472);
            this.listBoxDisplay.TabIndex = 0;
            // 
            // groupBoxFunctions
            // 
            this.groupBoxFunctions.Controls.Add(this.labelTime);
            this.groupBoxFunctions.Controls.Add(this.labelResults);
            this.groupBoxFunctions.Controls.Add(this.buttonBinary);
            this.groupBoxFunctions.Controls.Add(this.buttonSequential);
            this.groupBoxFunctions.Controls.Add(this.buttonFileUpload);
            this.groupBoxFunctions.Controls.Add(this.textBoxInput);
            this.groupBoxFunctions.Controls.Add(this.labelInput);
            this.groupBoxFunctions.Location = new System.Drawing.Point(465, 94);
            this.groupBoxFunctions.Name = "groupBoxFunctions";
            this.groupBoxFunctions.Size = new System.Drawing.Size(327, 234);
            this.groupBoxFunctions.TabIndex = 1;
            this.groupBoxFunctions.TabStop = false;
            this.groupBoxFunctions.Text = "Functions";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(6, 30);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(78, 13);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Star to Search:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(90, 27);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(230, 20);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonFileUpload
            // 
            this.buttonFileUpload.Location = new System.Drawing.Point(9, 66);
            this.buttonFileUpload.Name = "buttonFileUpload";
            this.buttonFileUpload.Size = new System.Drawing.Size(311, 23);
            this.buttonFileUpload.TabIndex = 2;
            this.buttonFileUpload.Text = "Upload File";
            this.buttonFileUpload.UseVisualStyleBackColor = true;
            this.buttonFileUpload.Click += new System.EventHandler(this.buttonFileUpload_Click);
            // 
            // buttonSequential
            // 
            this.buttonSequential.Location = new System.Drawing.Point(6, 114);
            this.buttonSequential.Name = "buttonSequential";
            this.buttonSequential.Size = new System.Drawing.Size(129, 23);
            this.buttonSequential.TabIndex = 4;
            this.buttonSequential.Text = "Sequential Search";
            this.buttonSequential.UseVisualStyleBackColor = true;
            this.buttonSequential.Click += new System.EventHandler(this.buttonSequential_Click);
            // 
            // buttonBinary
            // 
            this.buttonBinary.Location = new System.Drawing.Point(192, 114);
            this.buttonBinary.Name = "buttonBinary";
            this.buttonBinary.Size = new System.Drawing.Size(129, 23);
            this.buttonBinary.TabIndex = 5;
            this.buttonBinary.Text = "Binary Search";
            this.buttonBinary.UseVisualStyleBackColor = true;
            this.buttonBinary.Click += new System.EventHandler(this.buttonBinary_Click);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(7, 157);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(45, 13);
            this.labelResults.TabIndex = 6;
            this.labelResults.Text = "Results:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(7, 186);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(67, 13);
            this.labelTime.TabIndex = 7;
            this.labelTime.Text = "Time Taken:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Upload Desired File (starSorted, starUnsorted)\r\n2. Use Sequential for Unsorted" +
    ", and Binary for Sorted.\r\n3. Searches ARE Case-Sensative\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFunctions);
            this.Controls.Add(this.listBoxDisplay);
            this.Name = "Form1";
            this.Text = "Star Searching";
            this.groupBoxFunctions.ResumeLayout(false);
            this.groupBoxFunctions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.GroupBox groupBoxFunctions;
        private System.Windows.Forms.Button buttonFileUpload;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonBinary;
        private System.Windows.Forms.Button buttonSequential;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label label1;
    }
}

