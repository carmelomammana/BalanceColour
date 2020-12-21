using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject prefabBall;
    public List<Material> colours;
    public Transform spawnPos;
    public float timeToSpawn;

    private float timer;
    private float totalTimePassed;
    System.Random random; 
    void Start()
    {
        InitGame();
    }

    void Update()
    {
        timer += Time.deltaTime;
        totalTimePassed += Time.deltaTime;
        if (timer > timeToSpawn)
            SpawnBall();

        if (totalTimePassed >= 10)
        {
            timeToSpawn -= 0.5f;
            totalTimePassed = 0;
        }
    }

    void InitGame()
    {
        totalTimePassed = 0;
        timer = 3.8f;
        random = new System.Random(Guid.NewGuid().GetHashCode());
    }

    void SpawnBall()
    {
        GameObject g = Instantiate(prefabBall, spawnPos.position, prefabBall.transform.rotation);
        g.GetComponent<Ball>().colour = colours[GetRandomColour()];
        timer = 0;
    }

    int GetRandomColour()
    {
        return random.Next(0, colours.Count);
    }
}
