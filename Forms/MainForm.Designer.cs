namespace PSP_Tools_2
{
    partial class MainForm
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
            saveEditorButton = new Button();
            SuspendLayout();
            // 
            // saveEditorButton
            // 
            saveEditorButton.FlatStyle = FlatStyle.Popup;
            saveEditorButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveEditorButton.Image = Properties.Resources.saveDataEditor1;
            saveEditorButton.Location = new Point(34, 30);
            saveEditorButton.Name = "saveEditorButton";
            saveEditorButton.Size = new Size(132, 106);
            saveEditorButton.TabIndex = 0;
            saveEditorButton.Text = "Save Editor";
            saveEditorButton.UseVisualStyleBackColor = true;
            saveEditorButton.Click += SaveEditorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(605, 290);
            Controls.Add(saveEditorButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "PSP Tools 2";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button saveEditorButton;
    }
}
