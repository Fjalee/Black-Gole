using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    [SerializeField]
    private SceneLoader.Scene _scene;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        if (other.gameObject.tag == "PlanetBall")
        {
            if (gameObject.name == "BlackHole")
            {
                Debug.Log(_scene.ToString());
                SceneLoader.LoadHeavy(_scene);
                return;
            }
            if (gameObject.name.Contains("Star"))
            {
                DeathsCounter.instance.AddDeathByStar();
            }
            SceneLoader.Reload();
        }
    }
}
