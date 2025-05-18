namespace PSP_Tools_2
{
    partial class deleteConfirmDialog
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
            Cancel = new Button();
            Comfirm = new Button();
            backupCheck = new CheckBox();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.Location = new Point(133, 100);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(115, 29);
            Cancel.TabIndex = 0;
            Cancel.Text = "Go &Back";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Comfirm
            // 
            Comfirm.Location = new Point(12, 100);
            Comfirm.Name = "Comfirm";
            Comfirm.Size = new Size(115, 29);
            Comfirm.TabIndex = 1;
            Comfirm.Text = "&Delete";
            Comfirm.UseVisualStyleBackColor = true;
            Comfirm.Click += Comfirm_Click;
            // 
            // backupCheck
            // 
            backupCheck.AutoSize = true;
            backupCheck.BackColor = Color.Transparent;
            backupCheck.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backupCheck.Location = new Point(12, 61);
            backupCheck.Name = "backupCheck";
            backupCheck.Size = new Size(222, 24);
            backupCheck.TabIndex = 2;
            backupCheck.Text = "Create Backup for Restoring";
            backupCheck.UseVisualStyleBackColor = false;
            backupCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.BackColor = Color.Transparent;
            messageLabel.Location = new Point(12, 9);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(185, 40);
            messageLabel.TabIndex = 3;
            messageLabel.Text = "Are you SURE you want to \r\ndelete your save data?";
            messageLabel.Click += label1_Click;
            // 
            // deleteConfirmDialog
            // 
            AcceptButton = Comfirm;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.saveDataEditor1;
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = Cancel;
            ClientSize = new Size(266, 141);
            Controls.Add(messageLabel);
            Controls.Add(backupCheck);
            Controls.Add(Comfirm);
            Controls.Add(Cancel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "deleteConfirmDialog";
            Text = "deleteConfirmDialog";
            TopMost = true;
            Load += deleteConfirmDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel;
        private Button Comfirm;
        private CheckBox backupCheck;
        private Label messageLabel;
    }
}