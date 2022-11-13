using UnityEngine;

public class PlanetBallAudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioFlying;

    private Rigidbody _rigidBody;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        UpdateFlyingAudio();
    }

    private void UpdateFlyingAudio()
    {
        float minPitch = 0.3f;
        _audioFlying.pitch = 0.1f * minPitch * GetMaxElement(_rigidBody.velocity);

        if (_rigidBody.velocity != Vector3.zero && !_audioFlying.isPlaying)
        {
            _audioFlying.Play();
        }
    }

    private float GetMaxElement(Vector3 vect)
    {
        return Mathf.Max(Mathf.Max(vect.x, vect.y), vect.z);
    }
}
