using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TMP_Text[] Play;
    [SerializeField] private TMP_Text[] Credits;
    [SerializeField] private TMP_Text[] Quit;
    [SerializeField] private TMP_Text[] HighScoreText;
    [SerializeField] private TMP_Text[] PointsText;

    void Start()
    {
        for (int i=0;i<Play.Length;i++){
            Play[i].text="Play";
             Credits[i].text="Credits";
            Quit[i].text="Quit";
            HighScoreText[i].text="High\nScore";
        }
       

         HighScoreManager highScoreManager = FindObjectOfType<HighScoreManager>();
        if (highScoreManager != null)
        {
            HighScoreManager.PlayerScore highScore = highScoreManager.LoadHighScore();

            // Mostrar la puntuación en el texto de la UI
            if (highScore != null)
            {
                for (int i=0;i<PointsText.Length;i++){
                    PointsText[i].text = $"{highScore.highScore}";
                }
             
            }
            else
            {
                for (int i=0;i<PointsText.Length;i++){
                    PointsText[i].text = "0";
                }
            }
        }
        else
        {
            Debug.LogError("HighScoreManager not found in the scene!");
        }
    }

    public void QuitGame(){
        Application.Quit();
    }
   public void LoadScene(string SceneName){
    SceneManager.LoadScene(SceneName);
   }
}
