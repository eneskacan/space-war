using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    GameObject spaceshipPrefab;

    [SerializeField]
    List<GameObject> asteroidPrefabs = new List<GameObject>();

    GameObject spaceship;
    List<GameObject> asteroids = new List<GameObject>();

    [SerializeField]
    int diffuculty = 1;

    [SerializeField]
    int waveCouont = 5;

    UIControl uiControl;

    private void Awake()
    {
        ScreenData.Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        uiControl = GetComponent<UIControl>();
    }

    public void StartGame()
    {
        spaceship = Instantiate(spaceshipPrefab);
        spaceship.transform.position = new Vector3(0, ScreenData.Down + 1.5f);

        spawnAsteroid(5);
        uiControl.GameStarted();
    }

    void spawnAsteroid(int number)
    {
        Vector3 position = new Vector3();

        for (int i = 0; i < number; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(ScreenData.Left, ScreenData.Right);
            position.y = ScreenData.Up - 1;

            GameObject asteroid = Instantiate(asteroidPrefabs[Random.Range(0, asteroidPrefabs.Count)], position, Quaternion.identity);
            asteroids.Add(asteroid);
        }
    }

    public void asteroidDestroyed(GameObject asteroid)
    {
        uiControl.IncreaseScore(asteroid);
        asteroids.Remove(asteroid);

        if (asteroids.Count <= diffuculty)
        {
            diffuculty++;
            spawnAsteroid(diffuculty * waveCouont);
        }
    }

    public void GameOver()
    {
        Debug.Log(asteroids.Count);
        foreach (GameObject a in asteroids.ToArray())
            a.gameObject.GetComponent<Asteroid>().DestroyAsteroid();

        asteroids.Clear();
        diffuculty = 1;

        uiControl.GameOver();
    }
}
