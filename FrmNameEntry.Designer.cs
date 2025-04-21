namespace TimerControl
{
    partial class FrmNameEntry
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
            lblNameEntry = new Label();
            txtName = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblNameEntry
            // 
            lblNameEntry.AutoSize = true;
            lblNameEntry.Location = new Point(31, 20);
            lblNameEntry.Name = "lblNameEntry";
            lblNameEntry.Size = new Size(117, 20);
            lblNameEntry.TabIndex = 0;
            lblNameEntry.Text = "Enter your name";
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(439, 27);
            txtName.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(44, 99);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // FrmNameEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 199);
            Controls.Add(btnOk);
            Controls.Add(txtName);
            Controls.Add(lblNameEntry);
            Name = "FrmNameEntry";
            Text = "Name Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameEntry;
        private TextBox txtName;
        private Button btnOk;
    }
}