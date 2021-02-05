using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float totalTime = 0;
    float currentTime = 0;
    bool running = false;

    public float TotalTime
    {
        set { this.totalTime = value; }
    }

    public void Start()
    {
        if(totalTime > 0)
        {
            running = true;
            currentTime = 0;
        }
    }

    public bool Done
    {
        get { return currentTime >= totalTime; }
    }

    // Update is called once per frame
    void Update()
    {
        if(running)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= totalTime)
            {
                running = false;
            }
        }        
    }
}
