namespace TimerControl
{
    partial class FrmHighScores
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
            listBoxScores = new ListBox();
            lblHighScores = new Label();
            SuspendLayout();
            // 
            // listBoxScores
            // 
            listBoxScores.BackColor = SystemColors.InactiveCaptionText;
            listBoxScores.ForeColor = Color.Gold;
            listBoxScores.FormattingEnabled = true;
            listBoxScores.ItemHeight = 24;
            listBoxScores.Location = new Point(84, 55);
            listBoxScores.Margin = new Padding(5, 4, 5, 4);
            listBoxScores.Name = "listBoxScores";
            listBoxScores.Size = new Size(984, 388);
            listBoxScores.TabIndex = 0;
            // 
            // lblHighScores
            // 
            lblHighScores.AutoSize = true;
            lblHighScores.Location = new Point(84, 28);
            lblHighScores.Margin = new Padding(5, 0, 5, 0);
            lblHighScores.Name = "lblHighScores";
            lblHighScores.Size = new Size(134, 24);
            lblHighScores.TabIndex = 1;
            lblHighScores.Text = "High Scores";
            // 
            // FrmHighScores
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1123, 487);
            Controls.Add(lblHighScores);
            Controls.Add(listBoxScores);
            Font = new Font("Snap ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.DarkSlateGray;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmHighScores";
            Text = "High Scores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxScores;
        private Label lblHighScores;
    }
}