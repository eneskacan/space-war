using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;
    GameObject spaceshipPrefab;

    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.TotalTime = 3;
        timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Done)
        {
            SpawnAsteroid();
            timer.Start();
        }
    }

    void SpawnAsteroid()
    {
        Instantiate(asteroidPrefab);
    }
}
