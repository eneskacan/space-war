using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField]
    AudioClip asteroidExplosion;

    [SerializeField]
    AudioClip spaceshipExplosion;

    [SerializeField]
    AudioClip fire;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AsteroidExplosion()
    {
        audioSource.PlayOneShot(asteroidExplosion);
    }

    public void SpaceshipExplosion()
    {
        audioSource.PlayOneShot(spaceshipExplosion);
    }

    public void Fire()
    {
        audioSource.PlayOneShot(fire, 0.4f);
    }
}
