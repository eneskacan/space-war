using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Spaceship spaceship1 = new Spaceship(Random.Range(1, 200), "Black");
        Spaceship spaceship2 = new Spaceship(Random.Range(1, 100));

        if(spaceship1.MaxSpeed > spaceship2.MaxSpeed)
        {
            Debug.Log("2. GEMİ KAZANDI!!!!!!");
        }
        else
        {
            Debug.Log("1. GEMİ KAZANDIIIII1!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
