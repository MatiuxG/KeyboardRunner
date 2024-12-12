using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class PlayVideo : MonoBehaviour
{
   public VideoPlayer videoPlayer; // Arrastra tu VideoPlayer desde el Inspector
    public string nextSceneName;   // Nombre de la escena a cargar después del video

    void Start()
    {
        // Asegúrate de que el VideoPlayer esté asignado
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        // Escucha el evento que ocurre cuando el video finaliza
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Cambiar a la escena especificada
        SceneManager.LoadScene(nextSceneName);
    }

}
