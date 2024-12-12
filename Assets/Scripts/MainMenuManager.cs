using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;

public class MainMenuManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TMP_Text Play;
    [SerializeField] private TMP_Text Credits;
    [SerializeField] private TMP_Text Quit;

    void Start()
    {
        Play.text="Play";
        Credits.text="Credits";
        Quit.text="Quit";
    }

    public void QuitGame(){
        Application.Quit();
    }
   public void LoadScene(string SceneName){
    SceneManager.LoadScene(SceneName);
   }
}
