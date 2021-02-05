using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship
{
    /// <summary>
    /// Max speed of the spaceship
    /// </summary>
    int maxSpeed;

    /// <summary>
    /// Color of the spaceshio
    /// </summary>
    string color;
    
    /// <summary>
    /// Create a spacechip with speed and color
    /// </summary>
    /// <param name="maxSpeed"></param>
    /// <param name="color"></param>
    public Spaceship(int maxSpeed, string color = "Red")
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
    }

    /// <summary>
    /// Return max speed of the spaceship
    /// </summary>
    public int MaxSpeed
    {
        get { return maxSpeed; }
    }

    /// <summary>
    /// Return color of the spaceship
    /// </summary>
    public string Color
    {
        get { return color; }
    }
}
