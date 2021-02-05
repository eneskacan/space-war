using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    MeshRenderer mashRenderer;
    // Start is called before the first frame update
    void Start()
    {
        mashRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = 0.1f * Time.time;
        mashRenderer.material.SetTextureOffset("_MainTex", new Vector2(0, y));
    }
}
