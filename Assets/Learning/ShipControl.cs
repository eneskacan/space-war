using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    const float speed = 5.0f;
    const float rotationSpeed = 5.0f;

    bool topluyor = false;
    GameObject hedef;

    Rigidbody2D rigidbody2D;
    Toplayıcı toplayıcı;

    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        toplayıcı = Camera.main.GetComponent<Toplayıcı>();
    }

    void OnMouseDown()
    {
        if (!topluyor)
        {
            GitVeTople();
            topluyor = true;
        }
    }

    void GitVeTople()
    {
        hedef = toplayıcı.HedefStar;
        if(hedef != null)
        {
            Vector2 gidilecekYer = new Vector2(hedef.transform.position.x - transform.position.x, hedef.transform.position.y - transform.position.y);
            gidilecekYer.Normalize();
            rigidbody2D.AddForce(gidilecekYer * speed, ForceMode2D.Impulse);
        }            
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == hedef)
        {
            toplayıcı.destroyStar(hedef);
            rigidbody2D.velocity = Vector2.zero;
            GitVeTople();
        }            
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = gameObject.transform.position;

        //if (Input.GetAxis("Vertical") != 0)
        //{
        //    position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //}

        //if(Input.GetAxis("Horizontal") != 0)
        //{
        //    position.x += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        //}

        //gameObject.transform.position = position;
    }
}
