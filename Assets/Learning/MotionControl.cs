using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionControl : MonoBehaviour
{
    float colliderBoy;
    float colliderEn;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-10, 10), Random.Range(-10, 10)), ForceMode2D.Impulse);
        BoxCollider2D collider2D = GetComponent<BoxCollider2D>();
        colliderBoy = collider2D.size.y / 2;
        colliderEn = collider2D.size.x / 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ÇARPIŞMAAAAAA!");
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);

        //gameObject.transform.position = position;
        //EkrandaKal();
    }

    void EkrandaKal()
    {
        Vector3 position = gameObject.transform.position;

        if(position.x - colliderEn < ScreenData.Left)
        {
            position.x = ScreenData.Left + colliderEn;
        }

        if (position.x + colliderEn >= ScreenData.Right)
        {
            position.x = ScreenData.Right - colliderEn;
        }

        if (position.y - colliderBoy < ScreenData.Down)
        {
            position.y = ScreenData.Down + colliderBoy;
        }

        if (position.y + colliderBoy >= ScreenData.Up)
        {
            position.y = ScreenData.Up - colliderBoy;
        }

        gameObject.transform.position = position;
    }
}
