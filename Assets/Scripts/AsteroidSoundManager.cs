using System.Collections;
using UnityEngine;

public class AsteroidSoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioAsteroidCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlanetBall")
        {
            _audioAsteroidCollision.Play();
        }
    }
}
