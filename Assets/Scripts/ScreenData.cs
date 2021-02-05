using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenData
{
    static float left;
    static float right;
    static float up;
    static float down;

    /// <summary>
    /// Stores left coordinate of the screen
    /// </summary>
    public static float Left
    {
        get { return left; }
    }

    /// <summary>
    /// Stores right coordinate of the screen
    /// </summary>
    public static float Right
    {
        get { return right; }
    }

    /// <summary>
    /// Stores up coordiante of the screen
    /// </summary>
    public static float Up
    {
        get { return up; }
    }

    /// <summary>
    /// Stores down coordinate of the screen
    /// </summary>
    public static float Down
    {
        get { return down; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static void Init()
    {
        float z = Camera.main.transform.position.z;
        Vector3 leftDown = new Vector3(0, 0, z);
        Vector3 rightUp = new Vector3(Screen.width, Screen.height, z);

        leftDown = Camera.main.ScreenToWorldPoint(leftDown);
        rightUp = Camera.main.ScreenToWorldPoint(rightUp);

        left = leftDown.x;
        right = rightUp.x;
        up = rightUp.y;
        down = leftDown.y;
    }
}
