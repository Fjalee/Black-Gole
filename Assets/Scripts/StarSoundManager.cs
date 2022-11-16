using UnityEngine;

public class StarSoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioStarCollision;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "PlanetBall")
        {
            _audioStarCollision.Play();
        }
    }
}
