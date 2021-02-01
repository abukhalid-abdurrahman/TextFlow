namespace TextFlow
{
    partial class Main
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
            this.recognizeBtn = new System.Windows.Forms.Button();
            this.recognizedTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // recognizeBtn
            // 
            this.recognizeBtn.Location = new System.Drawing.Point(404, 341);
            this.recognizeBtn.Name = "recognizeBtn";
            this.recognizeBtn.Size = new System.Drawing.Size(96, 32);
            this.recognizeBtn.TabIndex = 0;
            this.recognizeBtn.Text = "Recognize";
            this.recognizeBtn.UseVisualStyleBackColor = true;
            this.recognizeBtn.Click += new System.EventHandler(this.RecognizeBtn_Click);
            // 
            // recognizedTextBox
            // 
            this.recognizedTextBox.Location = new System.Drawing.Point(12, 12);
            this.recognizedTextBox.Name = "recognizedTextBox";
            this.recognizedTextBox.Size = new System.Drawing.Size(488, 323);
            this.recognizedTextBox.TabIndex = 1;
            this.recognizedTextBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 385);
            this.Controls.Add(this.recognizedTextBox);
            this.Controls.Add(this.recognizeBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button recognizeBtn;
        private System.Windows.Forms.RichTextBox recognizedTextBox;
    }
}

