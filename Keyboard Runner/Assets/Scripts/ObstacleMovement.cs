using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
        
    [Header("Variables")]
    [SerializeField] private float moveSpeed = 5f; // Velocidad de movimiento

    void Update()
    {
        // Mover el obstáculo hacia la izquierda
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // Destruir el obstáculo si sale de la pantalla
        if (transform.position.x < -10f) // Ajusta este valor según tu escena
        {
           
            Destroy(gameObject);
        }
    }
}
