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
            filepath1LB = new Label();
            filepath2LB = new Label();
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
            file2BTN.Location = new Point(529, 260);
            file2BTN.Name = "file2BTN";
            file2BTN.Size = new Size(150, 46);
            file2BTN.TabIndex = 1;
            file2BTN.Text = "button2";
            file2BTN.UseVisualStyleBackColor = true;
            file2BTN.Click += file2BTN_Click;
            // 
            // statusLB
            // 
            statusLB.Location = new Point(73, 106);
            statusLB.Name = "statusLB";
            statusLB.Size = new Size(606, 131);
            statusLB.TabIndex = 2;
            statusLB.Text = "label1";
            statusLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filepath1LB
            // 
            filepath1LB.Location = new Point(73, 319);
            filepath1LB.Name = "filepath1LB";
            filepath1LB.Size = new Size(243, 45);
            filepath1LB.TabIndex = 3;
            filepath1LB.Text = "label1";
            filepath1LB.TextAlign = ContentAlignment.MiddleCenter;
            filepath1LB.Click += filepath1LB_Click;
            // 
            // filepath2LB
            // 
            filepath2LB.Location = new Point(436, 319);
            filepath2LB.Name = "filepath2LB";
            filepath2LB.Size = new Size(243, 45);
            filepath2LB.TabIndex = 4;
            filepath2LB.Text = "label1";
            filepath2LB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 388);
            Controls.Add(filepath2LB);
            Controls.Add(filepath1LB);
            Controls.Add(statusLB);
            Controls.Add(file2BTN);
            Controls.Add(file1BTN);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button file1BTN;
        private Button file2BTN;
        private Label statusLB;
        private Label filepath1LB;
        private Label filepath2LB;
    }
}
