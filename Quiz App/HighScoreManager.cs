// HighScoreManager.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Quiz_App
{
    public static class HighScoreManager
    {
        private const string HighScoresFilePath = "highscores.txt";
        private const string CurrentUsernameFilePath = "currentusername.txt";

        public static List<HighScore> LoadHighScores()
        {
            List<HighScore> highScores = new List<HighScore>();

            if (File.Exists(HighScoresFilePath))
            {
                string[] lines = File.ReadAllLines(HighScoresFilePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int score))
                    {
                        highScores.Add(new HighScore { Name = parts[0], Score = score });
                    }
                }
            }

            return highScores.OrderByDescending(hs => hs.Score).ToList();
        }

        public static void SaveHighScore(string playerName, int score)
        {
            string line = $"{playerName}:{score}";

            File.AppendAllLines(HighScoresFilePath, new[] { line }, Encoding.UTF8);
        }

        public static void SaveCurrentUsername(string username)
        {
            File.WriteAllText(CurrentUsernameFilePath, username);
        }

        public static string GetCurrentUsername()
        {
            if (File.Exists(CurrentUsernameFilePath))
            {
                return File.ReadAllText(CurrentUsernameFilePath);
            }

            return string.Empty;
        }
    }

    public class HighScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
