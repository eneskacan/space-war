using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayıcı : MonoBehaviour
{
    [SerializeField]
    GameObject starPrefab;

    List<GameObject> stars = new List<GameObject>();

    /// <summary>
    /// Hedefdeki yıldızı söyler
    /// </summary>
    public GameObject HedefStar
    {
        get
        {
            if (stars.Count > 0)
                return stars[0];
            else
                return null;
        }
    }

    /// <summary>
    /// Destory the selected star
    /// </summary>
    /// <param name="star"></param>
    public void destroyStar(GameObject star)
    {
        stars.Remove(star);
        Debug.Log(stars.Count);
        Destroy(star);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            stars.Add(Instantiate(starPrefab, position, Quaternion.identity));
        }
    }
}
