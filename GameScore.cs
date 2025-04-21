using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerControl
{
    public class GameScore
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int Level { get; set; }
        public DateTime Date { get; set; }
        public string PlayerName { get; set; }

        // Constructor with parameters  
        public GameScore(int id, int score, int level, DateTime date, string playerName)
        {
            Id = id;
            Score = score;
            Level = level;
            Date = date;
            PlayerName = playerName;
        }

        public GameScore()
        {
        }
    }
}
