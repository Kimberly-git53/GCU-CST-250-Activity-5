using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace TimerControl
{
    public partial class FrmHighScores : Form
    {
        // Constructor of  list for game score
        public FrmHighScores(List<GameScore> scores)
        {
            InitializeComponent();
            // Sort the scores in descending order by score value
            foreach (var score in scores.OrderByDescending(s => s.Score))
            {
                // Format and add each score to the list box
                listBoxScores.Items.Add(
                    $"{score.PlayerName} | Score: {score.Score} | Level: {score.Level} | {score.Date:g}");
            }
        }
    }
}
