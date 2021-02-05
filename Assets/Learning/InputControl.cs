using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    List<GameObject> asteroids;

    // Start is called before the first frame update
    void Start()
    {
        asteroids = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            asteroids.Add(Instantiate(asteroidPrefab, position, Quaternion.identity));
        }

        if(Input.GetMouseButton(2))
        {
            foreach (GameObject g in asteroids)
                Destroy(g);
        }
    }
}
