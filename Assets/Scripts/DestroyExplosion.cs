using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.TotalTime = 1;
        timer.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Done)
        {
            Destroy(gameObject);
        }
    }
}
