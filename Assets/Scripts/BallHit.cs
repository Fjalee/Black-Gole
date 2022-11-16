using System.Collections;
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
                SceneLoader.LoadHeavy(_scene);
                return;
            }

            StartCoroutine(ReloadAfterSeconds(0.7f));
        }
    }

    private IEnumerator ReloadAfterSeconds(float secondsToWait)
    {
        yield return new WaitForSeconds(secondsToWait);
        SceneLoader.Reload();
    }
}
