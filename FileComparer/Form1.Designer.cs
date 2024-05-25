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
            button1 = new Button();
            extraStatusLB = new Label();
            SuspendLayout();
            // 
            // file1BTN
            // 
            file1BTN.BackColor = Color.FromArgb(225, 225, 225);
            file1BTN.FlatStyle = FlatStyle.Flat;
            file1BTN.ForeColor = Color.Black;
            file1BTN.Location = new Point(73, 278);
            file1BTN.Name = "file1BTN";
            file1BTN.Size = new Size(150, 46);
            file1BTN.TabIndex = 0;
            file1BTN.Text = "File1";
            file1BTN.UseVisualStyleBackColor = false;
            file1BTN.Click += file1BTN_Click;
            // 
            // file2BTN
            // 
            file2BTN.BackColor = Color.FromArgb(225, 225, 225);
            file2BTN.FlatStyle = FlatStyle.Flat;
            file2BTN.ForeColor = Color.Black;
            file2BTN.Location = new Point(529, 278);
            file2BTN.Name = "file2BTN";
            file2BTN.Size = new Size(150, 46);
            file2BTN.TabIndex = 1;
            file2BTN.Text = "File2";
            file2BTN.UseVisualStyleBackColor = false;
            file2BTN.Click += file2BTN_Click;
            // 
            // statusLB
            // 
            statusLB.BackColor = SystemColors.ControlDarkDark;
            statusLB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusLB.ForeColor = Color.White;
            statusLB.Location = new Point(73, 30);
            statusLB.Name = "statusLB";
            statusLB.Size = new Size(606, 183);
            statusLB.TabIndex = 2;
            statusLB.Text = "...";
            statusLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // filepath1LB
            // 
            filepath1LB.FlatStyle = FlatStyle.Popup;
            filepath1LB.ForeColor = Color.White;
            filepath1LB.Location = new Point(59, 337);
            filepath1LB.Name = "filepath1LB";
            filepath1LB.Size = new Size(620, 45);
            filepath1LB.TabIndex = 3;
            filepath1LB.Text = "<file1>";
            filepath1LB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // filepath2LB
            // 
            filepath2LB.FlatStyle = FlatStyle.Popup;
            filepath2LB.ForeColor = Color.White;
            filepath2LB.Location = new Point(59, 382);
            filepath2LB.Name = "filepath2LB";
            filepath2LB.Size = new Size(620, 45);
            filepath2LB.TabIndex = 4;
            filepath2LB.Text = "<file2>";
            filepath2LB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(225, 225, 225);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 54);
            button1.TabIndex = 5;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // extraStatusLB
            // 
            extraStatusLB.BackColor = SystemColors.ActiveCaption;
            extraStatusLB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extraStatusLB.ForeColor = Color.White;
            extraStatusLB.Location = new Point(73, 213);
            extraStatusLB.Name = "extraStatusLB";
            extraStatusLB.Size = new Size(606, 46);
            extraStatusLB.TabIndex = 6;
            extraStatusLB.Text = "...";
            extraStatusLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(752, 440);
            Controls.Add(extraStatusLB);
            Controls.Add(button1);
            Controls.Add(filepath2LB);
            Controls.Add(filepath1LB);
            Controls.Add(statusLB);
            Controls.Add(file2BTN);
            Controls.Add(file1BTN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button file1BTN;
        private Button file2BTN;
        private Label statusLB;
        private Label filepath1LB;
        private Label filepath2LB;
        private Button button1;
        private Label extraStatusLB;
    }
}
