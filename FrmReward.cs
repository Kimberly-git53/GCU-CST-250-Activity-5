using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerControl
{
    public partial class FrmReward : Form
    {
        //Properties
        private int rewardCount;
        public enum RewardType
        {
            None,
            IncreaseTime,
            IncreaseSize
        }
        // Stores the reward chosen
        public RewardType selectedReward { get; set; } = RewardType.None;
        // Constructor 
        public FrmReward(int rewardCount)
        {
            InitializeComponent();
            this.rewardCount = rewardCount;
             // Show stickers depending on reward count
            picbxReward1.Visible = rewardCount >= 1;
            picbxReward2.Visible = rewardCount >= 2;
            picbxReward3.Visible = rewardCount >= 3;

            // Enable reward selection only after collecting 3
            rbtnIncreaseTime.Visible = rewardCount >= 3;
            rbtnIncreaseSize.Visible = rewardCount >= 3;
           
        }
        // Play button event 
        private void btnPlay_Click(object sender, EventArgs e)
        {
            // If the player chose to increase time
            if (rbtnIncreaseTime.Checked)
            {
                selectedReward = RewardType.IncreaseTime;
                MessageBox.Show("You have used your reward to slow down the timer.");
                rewardCount = 0;
            }
            // If player chose to increase target size
            else if (rbtnIncreaseSize.Checked)
            {
                selectedReward = RewardType.IncreaseSize;
                MessageBox.Show("You have used your reward to make the target box bigger.");
                rewardCount = 0;
            }
            
            // Close the reward form and return to the game
            this.Close();
        }
    }
}
