using System.Timers;


namespace TimerControl
{
    public partial class FrmGame : Form
    {
        // Properties
        int elapsed = 0;
        int score = 0;
        int level = 0;
        int moveCounter = 0;
        int movesPerCycle = 5;
        int rewardCount = 0;
        Random rand = new Random();

        public List<GameScore> highScores = new List<GameScore>();
        

        // Constructor
        public FrmGame()
        {
            InitializeComponent();
            // Add level background print
            this.Paint += FrmGame_Paint;
            // Resize 
            this.Resize += FrmGame_Resize;

        }
        //Start button event
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // start timer
            timeMoveTarget.Start();
            lblTime.Visible = true;

        }
        // Stop button click event
        private void BtnStop_Click(object sender, EventArgs e)
        {
            // stop timer
            timeMoveTarget.Stop();
        }
        // Restart button click event
        private void BtnReset_Click(object sender, EventArgs e)
        {
            // reset timer
            timeMoveTarget.Stop();
            elapsed = 0;
            lblTime.Text = "00:00:00";
            score = 0;

            //Reset target size and timer interval
            btnTarget.Size = new Size (110, 56);
            movesPerCycle = 5;
            UpdateLabels();

            //Reset rewards
            rewardCount = 0;

            //Reset level
            level = 0;
            //Redraw background
            this.Invalidate();
        }
        // Method to move target to a new location
        private void TimeMoveTarget_Tick(object sender, EventArgs e)
        {
            // Increment elapsed time 
            elapsed++;
            moveCounter++;
            // Move target after assigned elapsed time
            if (moveCounter >= movesPerCycle)
            {
                moveCounter = 0;

                btnTarget.Visible = true;
                btnDecoy.Visible = true;
                //Set allowable target area
                Rectangle clientArea = this.ClientRectangle;
                clientArea.Width -= btnDecoy.Width;
                clientArea.Width -= btnTarget.Width;
                clientArea.Height -= btnDecoy.Height;
                clientArea.Height -= btnTarget.Height;

                Point targetLocation, decoyLocation;
                bool overlaps;
                do
                {
                    // Get random new locations
                    targetLocation = new Point(rand.Next(0, clientArea.Width),
                        rand.Next(0, clientArea.Height));
                    decoyLocation = new Point(rand.Next(0, clientArea.Width),
                        rand.Next(0, clientArea.Height));

                    // Check if the new location overlaps with any buttons
                    overlaps = false;

                    // Build rectangles
                    Rectangle targetRect = new Rectangle(targetLocation, btnTarget.Size);
                    Rectangle decoyRect = new Rectangle(decoyLocation, btnDecoy.Size);

                    // Check if decoy and target overlap
                    if (targetRect.IntersectsWith(decoyRect))
                    {
                        overlaps = true;
                    }
                    else
                    {
                        // Check if either over laps with other controls
                        foreach (Control ctrl in this.Controls)
                        {

                            if (ctrl is Button || ctrl is Label)
                            {
                                if (ctrl != btnTarget && ctrl != btnDecoy)
                                {
                                    // If there is a button overlap then the location is marked as an overlap area
                                    if (targetRect.IntersectsWith(ctrl.Bounds) || decoyRect.IntersectsWith(ctrl.Bounds))
                                    {
                                        overlaps = true;
                                        break;
                                    }
                                }
                            }
                        }

                    }
                }
                // Continue looping until no overlap is found
                while (overlaps);
                // Place the target and decoy in a new location
                btnTarget.Location = targetLocation;
                btnDecoy.Location = decoyLocation;

                // Assign target new background colors
                btnTarget.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                btnDecoy.BackColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
                UpdateLabels();

            }
        }
        // Method to rewrite label text 
        private void UpdateLabels()
        {
            // Update Time label
            TimeSpan timeSpan = TimeSpan.FromSeconds(elapsed);
            lblTime.Text = timeSpan.ToString(@"hh\:mm\:ss");

            // Update Score
            lblScore.Text = $"Score: {score}";
        }
        // Target button click event handler
        public void BtnTarget_Click(object sender, EventArgs e)
        {
            btnTarget.Visible = false;

            // Increment score when player hits the target
            score++;

            //Check if the player has leveled up
            if (score % 5 == 0)
            {
                level++;
                LevelUpChallenge(level);

                //Reward form will appear after completing a level
                rewardCount++;
                ShowRewardPopup();

                MessageBox.Show($"Level up! Level:{level}");
                this.Invalidate();
            }
            UpdateLabels();

        }
        // Method to call Reward Form
        public void ShowRewardPopup()
        {
            FrmReward rewardForm = new FrmReward(rewardCount);
            rewardForm.ShowDialog();
            if (rewardForm.selectedReward != FrmReward.RewardType.None)
            {
                ApplyReward(rewardForm.selectedReward);
                //Reset reward count after use 
                rewardCount = 0;
            }
        }
        // Method to apply rewards
        public void ApplyReward(FrmReward.RewardType type)
        {
            // Reward to increase time interval
            if (type == FrmReward.RewardType.IncreaseTime)
            {
                movesPerCycle = Math.Max(1, movesPerCycle + 2);
            }
            // Reward if they choose to increase target size 
            else if (type == FrmReward.RewardType.IncreaseSize)
            {
                int newRewardWidth = Math.Max(20, btnTarget.Width + 8);
                int newRewardHeight = Math.Max(20, btnTarget.Height + 8);
                btnTarget.Size = new Size(newRewardWidth, newRewardHeight);
            }
        }

        // Method assigning the level up challenges
        private void LevelUpChallenge(int level)
        {

            // If an even level target button size decreases
            if (level % 2 == 0)
            {
                int newWidth = Math.Max(20, btnTarget.Width - 5);
                int newHeight = Math.Max(20, btnTarget.Height - 5);
                btnTarget.Size = new Size(newWidth, newHeight);
                MessageBox.Show("Watch out the target has shrunk!");
            }
            // If an odd level timer will speed up by one second
            else
            {
                movesPerCycle = Math.Max(1, movesPerCycle - 1 );
                MessageBox.Show("It's getting faster!");
                UpdateLabels();
            }

        }

        // Method to assign the game to be over when the target is missed
        private void FrmGame_Click(object sender, EventArgs e)
        {
            GameOver();
        }
        // Method to end the game
        private void GameOver()
        {
            timeMoveTarget.Stop();
            //Reset rewards
            rewardCount = 0; 
            
            
            using (FrmNameEntry form2 = new FrmNameEntry("Enter Your Name", "Enter your name:"))
            {
                // If the player loses the game populate player information on the high score form
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    string playerName = form2.InputText;
                    GameScore gameScore = new GameScore();
                    gameScore.Score = score;
                    gameScore.Level = level;
                    gameScore.Date = DateTime.Now;
                    gameScore.PlayerName = playerName;
                    highScores.Add(gameScore);
                    MessageBox.Show("Game Over! Your name is: " + playerName);
                }
            }
            //Pull high score form
            FrmHighScores formHighScores = new FrmHighScores(highScores);
            formHighScores.ShowDialog();
        }
        //Level printed on the form
        public void FrmGame_Paint(object sender, PaintEventArgs e)
        {
            DrawLargeNumber(e.Graphics);
        }
        // Method to develop and assign the latest level form color and number
        private void DrawLargeNumber(Graphics graphics)
        {
            string number = level.ToString();
            int fontSize = this.ClientSize.Height;
            Font font = new Font("Arial", fontSize, FontStyle.Bold, GraphicsUnit.Pixel);

            //Create a semi-transparent brush
            Color semiTranparentColor = Color.FromArgb(10, Color.Black);
            Brush brush = new SolidBrush(semiTranparentColor);

            //Find the center of the form
            SizeF textSize = graphics.MeasureString(number, font);
            float x = (this.ClientSize.Width - textSize.Width) / 2;
            float y = (this.ClientSize.Height - textSize.Height) / 2;

            //Draw the number
            graphics.DrawString(number, font, brush, x, y);
        }
        //Method to ensure button is positioned in the same area when resized
        private void FrmGame_Resize(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                    ctrl.Top = this.ClientSize.Height - 45;

            }
        }
        // Decoy event 
        private void btnDecoy_Click(object sender, EventArgs e)
        {
            GameOver();
        }
    }
}
