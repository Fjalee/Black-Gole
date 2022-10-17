using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    private Vector2 _rotation = Vector2.zero;

    private bool _isPlanetLaunched;

    [SerializeField]
    private Rigidbody _planet;

    [SerializeField]
    private float _rotationSpeedX = 0.5f;

    [SerializeField]
    private float _rotationSpeedY = 0.25f;

    [SerializeField]
    private float _shootPower = 15f;

    void Update()
    {
        transform.position = _planet.position;

        if (!_isPlanetLaunched)
        {
            _planet.velocity = Vector3.zero;
        }
    }

    public void ReceiveTouchInput(Vector2 moveInput)
    {
        _rotation.x += -moveInput.x * _rotationSpeedX;
        _rotation.y += moveInput.y * _rotationSpeedY;
        transform.rotation = Quaternion.Euler(_rotation.y, _rotation.x, 0f);
    }

    public void ShootPlanet()
    {
        if (_isPlanetLaunched)
        {
            return;
        }

        _planet.velocity = transform.forward * _shootPower;
        _isPlanetLaunched = true;
    }
}
