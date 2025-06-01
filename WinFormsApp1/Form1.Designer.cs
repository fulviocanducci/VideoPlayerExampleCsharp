namespace WinFormsApp1
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
            GrpBoxVideo = new GroupBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // GrpBoxVideo
            // 
            GrpBoxVideo.Location = new Point(12, 12);
            GrpBoxVideo.Name = "GrpBoxVideo";
            GrpBoxVideo.Size = new Size(539, 301);
            GrpBoxVideo.TabIndex = 0;
            GrpBoxVideo.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(566, 124);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 361);
            Controls.Add(button1);
            Controls.Add(GrpBoxVideo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrpBoxVideo;
        private Button button1;
    }
}
