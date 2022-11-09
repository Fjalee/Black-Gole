using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    [SerializeField]
    private SceneLoader.Scene _scene;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlanetBall")
        {
            if (gameObject.name == "BlackHole")
            {
                SceneLoader.LoadHeavy(_scene);
                return;
            }

            Destroy(other.gameObject);
            SceneLoader.Reload();
        }
    }
}
