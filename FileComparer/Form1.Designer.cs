namespace FileComparer
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
            file1BTN = new Button();
            file2BTN = new Button();
            statusLB = new Label();
            SuspendLayout();
            // 
            // file1BTN
            // 
            file1BTN.Location = new Point(73, 260);
            file1BTN.Name = "file1BTN";
            file1BTN.Size = new Size(150, 46);
            file1BTN.TabIndex = 0;
            file1BTN.Text = "button1";
            file1BTN.UseVisualStyleBackColor = true;
            file1BTN.Click += file1BTN_Click;
            // 
            // file2BTN
            // 
            file2BTN.Location = new Point(548, 260);
            file2BTN.Name = "file2BTN";
            file2BTN.Size = new Size(150, 46);
            file2BTN.TabIndex = 1;
            file2BTN.Text = "button2";
            file2BTN.UseVisualStyleBackColor = true;
            file2BTN.Click += file2BTN_Click;
            // 
            // statusLB
            // 
            statusLB.AutoSize = true;
            statusLB.Location = new Point(168, 100);
            statusLB.Name = "statusLB";
            statusLB.Size = new Size(78, 32);
            statusLB.TabIndex = 2;
            statusLB.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusLB);
            Controls.Add(file2BTN);
            Controls.Add(file1BTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button file1BTN;
        private Button file2BTN;
        private Label statusLB;
    }
}
