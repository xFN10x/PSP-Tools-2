namespace PSP_Tools_2.Forms
{
    partial class taskForm
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
            text = new Label();
            progressBar1 = new ProgressBar();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(12, 18);
            text.Name = "text";
            text.Size = new Size(190, 20);
            text.TabIndex = 0;
            text.Text = "Currently: Making this form.";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 41);
            progressBar1.MarqueeAnimationSpeed = 30;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(288, 44);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.Enabled = false;
            cancelButton.Location = new Point(12, 87);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(288, 29);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // taskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 118);
            ControlBox = false;
            Controls.Add(cancelButton);
            Controls.Add(progressBar1);
            Controls.Add(text);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "taskForm";
            Text = "Doing something...";
            TopMost = true;
            Load += taskForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text;
        private ProgressBar progressBar1;
        private Button cancelButton;
    }
}