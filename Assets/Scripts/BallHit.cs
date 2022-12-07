using Inputs;
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
                other.gameObject.GetComponent<RememberLastTrajectory>().LevelCompleted = true;
                return;
            }
            if (gameObject.name.Contains("Star") && DeathsCounter.instance)
            {
                DeathsCounter.instance.AddDeathByStar();
            }
            SceneLoader.Reload();
        }
    }
}
