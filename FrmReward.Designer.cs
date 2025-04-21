namespace TimerControl
{
    partial class FrmReward
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReward));
            lblLevelUpdate = new Label();
            btnPlay = new Button();
            rbtnIncreaseTime = new RadioButton();
            grpBoxReward = new GroupBox();
            picbxReward3 = new PictureBox();
            picbxReward2 = new PictureBox();
            rbtnIncreaseSize = new RadioButton();
            picbxReward1 = new PictureBox();
            grpBoxReward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picbxReward3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbxReward2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbxReward1).BeginInit();
            SuspendLayout();
            // 
            // lblLevelUpdate
            // 
            lblLevelUpdate.AutoSize = true;
            lblLevelUpdate.BackColor = Color.Transparent;
            lblLevelUpdate.CausesValidation = false;
            lblLevelUpdate.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLevelUpdate.Location = new Point(336, 18);
            lblLevelUpdate.Name = "lblLevelUpdate";
            lblLevelUpdate.Size = new Size(153, 36);
            lblLevelUpdate.TabIndex = 0;
            lblLevelUpdate.Text = "Rewards";
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.PaleGoldenrod;
            btnPlay.Font = new Font("Snap ITC", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = Color.DarkOliveGreen;
            btnPlay.Location = new Point(186, 272);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 34);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // rbtnIncreaseTime
            // 
            rbtnIncreaseTime.BackColor = Color.Transparent;
            rbtnIncreaseTime.Font = new Font("Snap ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnIncreaseTime.ForeColor = Color.LightCoral;
            rbtnIncreaseTime.Location = new Point(6, 193);
            rbtnIncreaseTime.Name = "rbtnIncreaseTime";
            rbtnIncreaseTime.Size = new Size(213, 57);
            rbtnIncreaseTime.TabIndex = 2;
            rbtnIncreaseTime.TabStop = true;
            rbtnIncreaseTime.Text = "Increase Time Interval";
            rbtnIncreaseTime.UseVisualStyleBackColor = false;
            // 
            // grpBoxReward
            // 
            grpBoxReward.BackColor = Color.DarkSlateGray;
            grpBoxReward.Controls.Add(picbxReward3);
            grpBoxReward.Controls.Add(picbxReward2);
            grpBoxReward.Controls.Add(rbtnIncreaseSize);
            grpBoxReward.Controls.Add(picbxReward1);
            grpBoxReward.Controls.Add(rbtnIncreaseTime);
            grpBoxReward.Controls.Add(btnPlay);
            grpBoxReward.Location = new Point(185, 99);
            grpBoxReward.Name = "grpBoxReward";
            grpBoxReward.Size = new Size(461, 323);
            grpBoxReward.TabIndex = 4;
            grpBoxReward.TabStop = false;
            grpBoxReward.Text = "groupBox1";
            // 
            // picbxReward3
            // 
            picbxReward3.Image = (Image)resources.GetObject("picbxReward3.Image");
            picbxReward3.Location = new Point(319, 85);
            picbxReward3.Name = "picbxReward3";
            picbxReward3.Size = new Size(86, 75);
            picbxReward3.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxReward3.TabIndex = 9;
            picbxReward3.TabStop = false;
            // 
            // picbxReward2
            // 
            picbxReward2.Image = (Image)resources.GetObject("picbxReward2.Image");
            picbxReward2.Location = new Point(184, 85);
            picbxReward2.Name = "picbxReward2";
            picbxReward2.Size = new Size(86, 75);
            picbxReward2.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxReward2.TabIndex = 8;
            picbxReward2.TabStop = false;
            // 
            // rbtnIncreaseSize
            // 
            rbtnIncreaseSize.BackColor = Color.Transparent;
            rbtnIncreaseSize.Font = new Font("Snap ITC", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnIncreaseSize.ForeColor = Color.DeepSkyBlue;
            rbtnIncreaseSize.Location = new Point(243, 193);
            rbtnIncreaseSize.Name = "rbtnIncreaseSize";
            rbtnIncreaseSize.Size = new Size(196, 57);
            rbtnIncreaseSize.TabIndex = 7;
            rbtnIncreaseSize.TabStop = true;
            rbtnIncreaseSize.Text = "Increase Target Box Size";
            rbtnIncreaseSize.UseVisualStyleBackColor = false;
            // 
            // picbxReward1
            // 
            picbxReward1.Image = (Image)resources.GetObject("picbxReward1.Image");
            picbxReward1.Location = new Point(44, 85);
            picbxReward1.Name = "picbxReward1";
            picbxReward1.Size = new Size(86, 75);
            picbxReward1.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxReward1.TabIndex = 4;
            picbxReward1.TabStop = false;
            // 
            // FrmReward
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(grpBoxReward);
            Controls.Add(lblLevelUpdate);
            Name = "FrmReward";
            Text = "FrmReward";
            grpBoxReward.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picbxReward3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbxReward2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbxReward1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLevelUpdate;
        private Button btnPlay;
        private RadioButton rbtnIncreaseTime;
        private GroupBox grpBoxReward;
        private PictureBox picbxReward1;
        private RadioButton rbtnIncreaseSize;
        private PictureBox picbxReward3;
        private PictureBox picbxReward2;
    }
}