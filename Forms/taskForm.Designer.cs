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
            // taskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 143);
            Controls.Add(text);
            Name = "taskForm";
            Text = "Doing something...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text;
    }
}