using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
     [Header("References")]
     [SerializeField]private GameObject GameOverCanvas;
     [SerializeField]private GameObject ScoreCanvas;
     [SerializeField]private GameObject PauseCanvas;
     
     [SerializeField]private PlayerController playerToObserve;
     [SerializeField]private TextMeshProUGUI ScoreText; // Mostrar Tecla por Pantalla

     public Action ChangeSpawnVelocity;
   
     [Header("Variables")]
     private bool IsPaused;

     private bool gameEnd=false;

     private int points;

     string pointsLanguage="Points"; //Futura apatacion de idiomas
    void Start()
    {
        CursorState(false);
        GameOverCanvas.SetActive(false);
        PauseCanvas.SetActive(false);
        ScoreCanvas.SetActive(true);
        points=0;
        IsPaused=false;
        playerToObserve=FindAnyObjectByType<PlayerController>();
        ScoreText.text= $"{pointsLanguage}: {points}";
        
        ///Observers
        playerToObserve.OnCollisionDetected+=GameOver;
        playerToObserve.PauseGame+=PauseGame;
        playerToObserve.AddPoint+=Addpoint;
    }

    void Awake(){
        Time.timeScale=1;
    }
    public void GameOver(){
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        CursorState(true);
        HighScoreManager highScoreManager = FindObjectOfType<HighScoreManager>();
        highScoreManager.SaveHighScore(points);
        highScoreManager.ShowHighScore();
        gameEnd=true;
    }
      public void PauseGame(){
        if(!gameEnd){
           Time.timeScale = IsPaused? 1 : 0;
            IsPaused=!IsPaused;
            PauseCanvas.SetActive(IsPaused);
            CursorState(IsPaused);  
        }
      }

    public void LoadScene(string SceneName){
        SceneManager.LoadScene(SceneName);
    }

    public void Addpoint(){
        points+=1;

        ScoreText.text= $"{pointsLanguage}: {points}";

        if (points%10==0){
             ChangeSpawnVelocity?.Invoke();
             Debug.Log("Velocidad Cambiada");
        }

    }

    void CursorState(bool state){
        Cursor.visible = state;
        Cursor.lockState=state?CursorLockMode.None:CursorLockMode.Locked;

    }


}
