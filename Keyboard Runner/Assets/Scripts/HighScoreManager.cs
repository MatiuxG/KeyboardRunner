using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    [System.Serializable]
    public class PlayerScore
    {
        public int highScore;
    }

    public void SaveHighScore(int score)
    {
        PlayerScore currentScore = LoadHighScore();

        if (currentScore == null || score > currentScore.highScore)
        {
            PlayerScore newScore = new PlayerScore
            {
                highScore = score
            };

            string json = JsonUtility.ToJson(newScore);
            string path = Application.persistentDataPath + "/highScore.json";
            System.IO.File.WriteAllText(path, json);

            Debug.Log($"New high score saved: {newScore.highScore}");
        }
        else
        {
            Debug.Log("Score is not higher than the current high score.");
        }
    }

    public PlayerScore LoadHighScore()
    {
        string path = Application.persistentDataPath + "/highScore.json";

        if (System.IO.File.Exists(path))
        {
            string json = System.IO.File.ReadAllText(path);
            PlayerScore highScore = JsonUtility.FromJson<PlayerScore>(json);
            Debug.Log($"High score loaded: {highScore.highScore}");
            return highScore;
        }
        else
        {
            Debug.Log("No high score file found.");
            return null;
        }
    }

    public void ShowHighScore()
    {
        PlayerScore highScore = LoadHighScore();

        if (highScore != null)
        {
            Debug.Log($"Current High Score: {highScore.highScore}");
            // Actualiza un elemento de la UI si es necesario
            // highScoreText.text = "High Score: " + highScore.highScore;
        }
        else
        {
            Debug.Log("No high score available.");
            // highScoreText.text = "High Score: 0";
        }
    }
}
