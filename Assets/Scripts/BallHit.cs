using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlanetBall")
        {
            Destroy(other.gameObject);
            SceneLoader.Reload();
        }
    }
}
