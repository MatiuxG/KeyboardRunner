using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("References")]
   [SerializeField] private GameObject obstaclePrefab; // Prefab del obstáculo
    public Transform spawnPoint;     // Punto donde se generarán los obstáculos
    
    [Header("Variables")]
    [SerializeField]private float spawnInterval = 2f; // Intervalo entre generación de obstáculos

    private float timer;             // Temporizador interno

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    private void SpawnObstacle()
    {
        // Generar el obstáculo en el punto de spawn
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
    }
}
