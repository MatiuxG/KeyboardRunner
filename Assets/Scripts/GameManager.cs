using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
     [Header("References")]
     [SerializeField]private GameObject GameOverCanvas;
     [SerializeField]private GameObject ScoreCanvas;

     [SerializeField]private TextMeshProUGUI ScoreText; // Mostrar Tecla por Pantalla
   

     private int points;

     string pointsLanguage="Puntos"; //Futura apatacion de idiomas
    void Start()
    {
        GameOverCanvas.SetActive(false);
        ScoreCanvas.SetActive(true);
        points=0;
        ScoreText.text= $"{pointsLanguage}: {points}";
    }
    public void GameOver(){
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void LoadScene(string SceneName){
        SceneManager.LoadScene(SceneName);
    }

    public void Addpoint(){
        points+=1;

       ScoreText.text= $"{pointsLanguage}: {points}";
    }

}
