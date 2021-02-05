using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour
{
    [SerializeField]
    GameObject firePrefab;

    [SerializeField]
    GameObject explosionPrefab;

    GameControl gameControl;

    const float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameControl = Camera.main.GetComponent<GameControl>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = gameObject.transform.position;

        if (Input.GetAxis("Vertical") != 0)
        {
            position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }

        gameObject.transform.position = position;
        position.y += 1;

        if(Input.GetButtonDown("Jump"))
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>().Fire();
            Vector3 firePosition = gameObject.transform.position;
            Instantiate(firePrefab, firePosition, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>().SpaceshipExplosion();

            GameObject explosion1 = Instantiate(explosionPrefab, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

            GameObject explosion2 = Instantiate(explosionPrefab, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);

            gameControl.GameOver();
        }
    }
}
