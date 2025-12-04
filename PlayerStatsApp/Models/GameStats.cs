using System.Collections.Generic;

namespace PlayerStatsApp.Models
{
    public class GameStats
    {
        public string GameName { get; set; }  = string.Empty;
        public int HighScore { get; set;  }
        public double HoursPlayed { get; set; }

        public GameStats() {}


        public static List<string> AvailableGames = new List<string>
        {
            "Rivals of Ether",
            "Cyber Quest",
            "Gate 3",
            "Crossing Paths",
            "Mystic Lands"
        };


        public GameStats(string gameName, int highScore, double hoursPlayed)
        {
            GameName = gameName;
            HighScore = highScore;
            HoursPlayed = hoursPlayed;
        }

        public override string ToString()
        {
            return $"Game: {GameName}, Highest Score: {HighScore}, Hours Played: {HoursPlayed}";
        }
    }
}


