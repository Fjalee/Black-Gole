using UnityEngine;

public class PlanetBallAudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource _launchAudio;

    private Rigidbody _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (_rigidBody.velocity != Vector3.zero && !_launchAudio.isPlaying)
        {
            _launchAudio.Play();
        }
    }
}
