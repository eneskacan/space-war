using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject explosionPrefab;

    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.TotalTime = Random.Range(5, 20);
        timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Done)
        {
            GameObject explosion = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
