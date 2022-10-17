using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHit : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlanetBall")
        {
            Debug.Log("consume ball");
            Destroy(other.gameObject);
        }
    }
}
