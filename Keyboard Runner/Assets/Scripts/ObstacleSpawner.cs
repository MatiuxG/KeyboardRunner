using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject obstaclePrefab; // Prefab del obstáculo
    [SerializeField] private GameManager gameManagerToObserve; // GameManager
    [SerializeField] private Transform spawnPoint;     // Punto donde se generarán los obstáculos
    
    [Header("Variables")]
    [SerializeField]private float spawnInterval = 2f; // Intervalo entre generación de obstáculos
    [SerializeField] private float spawnIntervalChange=0.1f;

    private float timer;             // Temporizador interno

    void Start()
    {
       gameManagerToObserve=FindAnyObjectByType<GameManager>();
       gameManagerToObserve.ChangeSpawnVelocity+=ChangeSpawnInterval;
    }

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

    private void ChangeSpawnInterval(){
        spawnInterval=spawnInterval==0.8f? 0.8f : spawnInterval-spawnIntervalChange;
    }

    public float getspawnInterval(){
        return spawnInterval;
    }
}
