using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField]
    GameObject explosionPrefab;

    GameControl gameControl;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        gameControl = Camera.main.GetComponent<GameControl>();

        if(Random.Range(0, 2) == 1)
        {
            rigidbody.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
        }
        else
        {
            rigidbody.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
        }

        rigidbody.AddTorque(Random.Range(-3.0f, 3.0f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fire")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>().AsteroidExplosion();
            gameControl.asteroidDestroyed(gameObject);
            DestroyAsteroid();
            Destroy(collision.gameObject);
        }
    }

    public void DestroyAsteroid()
    {
        GameObject explosion = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
