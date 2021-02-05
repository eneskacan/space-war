using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        timer = gameObject.AddComponent<Timer>();
        timer.TotalTime = 3;
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
