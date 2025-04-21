
namespace TimerControl
{
    partial class FrmGame
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
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnRestart = new Button();
            timeMoveTarget = new System.Windows.Forms.Timer(components);
            btnTarget = new Button();
            lblScore = new Label();
            btnDecoy = new Button();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(24, 20);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(63, 20);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00:00";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSeaGreen;
            btnStart.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.ForeColor = Color.SaddleBrown;
            btnStart.Location = new Point(12, 551);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 42);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.DarkSalmon;
            btnStop.Font = new Font("Segoe Print", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.ForeColor = Color.DarkSlateGray;
            btnStop.Location = new Point(112, 551);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(95, 42);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += BtnStop_Click;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.MediumAquamarine;
            btnRestart.Font = new Font("Segoe Print", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestart.Location = new Point(223, 551);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 42);
            btnRestart.TabIndex = 3;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += BtnReset_Click;
            // 
            // timeMoveTarget
            // 
            timeMoveTarget.Enabled = true;
            timeMoveTarget.Interval = 1000;
            timeMoveTarget.Tick += TimeMoveTarget_Tick;
            // 
            // btnTarget
            // 
            btnTarget.Location = new Point(333, 94);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(110, 56);
            btnTarget.TabIndex = 4;
            btnTarget.Text = "Target";
            btnTarget.UseVisualStyleBackColor = true;
            btnTarget.Click += BtnTarget_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(25, 52);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(49, 20);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score:";
            // 
            // btnDecoy
            // 
            btnDecoy.Location = new Point(207, 199);
            btnDecoy.Name = "btnDecoy";
            btnDecoy.Size = new Size(110, 56);
            btnDecoy.TabIndex = 6;
            btnDecoy.Text = "Decoy";
            btnDecoy.UseVisualStyleBackColor = true;
            btnDecoy.Click += btnDecoy_Click;
            // 
            // FrmGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = Properties.Resources.Gemini_Generated_Image_tw2vbltw2vbltw2v;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(670, 605);
            Controls.Add(btnDecoy);
            Controls.Add(lblScore);
            Controls.Add(btnTarget);
            Controls.Add(btnRestart);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTime);
            Name = "FrmGame";
            Text = "Whack-a-Mole";
            Click += FrmGame_Click;
            Paint += FrmGame_Paint;
            Resize += FrmGame_Resize;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblTime;
        private Button btnStart;
        private Button btnStop;
        private Button btnRestart;
        private System.Windows.Forms.Timer timeMoveTarget;
        private Button btnTarget;
        private Label lblScore;
        private Button btnDecoy;
    }
}
