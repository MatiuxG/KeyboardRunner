using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingGround : MonoBehaviour
{
 [Header("References")]
    [SerializeField] private Material groundMaterial; // Material del suelo
    [SerializeField] private ObstacleSpawner obstacleSpawner; // Referencia al generador de obstáculos
    [SerializeField] private float scrollSpeed = 5f; // Velocidad base del desplazamiento

    private Vector2 offset; // Desplazamiento del material

    void Start()
    {
        // Asegúrate de que el Renderer tenga un material asignado
        if (groundMaterial == null)
        {
            groundMaterial = GetComponent<Renderer>().material;
        }

        // Verifica si el material tiene un modo de repetición adecuado
        if (groundMaterial.mainTexture.wrapMode != TextureWrapMode.Repeat)
        {
            Debug.LogWarning("El modo de textura del material no está configurado como 'Repeat'. Esto puede causar problemas con el desplazamiento.");
        }
    }

    void Update()
    {
        // Calcula el desplazamiento horizontal
        offset = new Vector2(scrollSpeed * Time.time, 0); // Movimiento horizontal
        groundMaterial.mainTextureOffset = offset; // Aplica el desplazamiento
    }
}

