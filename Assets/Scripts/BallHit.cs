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
            if (gameObject.name.Contains("Star"))
            {
                DeathsCounter.instance.AddDeathByStar();
            }
            SceneLoader.Reload();
        }
    }
}
