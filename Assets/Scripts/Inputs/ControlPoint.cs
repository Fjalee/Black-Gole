using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    private Vector2 _rotation = Vector2.zero;

    private bool _isPlanetLaunched;

    [SerializeField]
    private Rigidbody _planet;

    [SerializeField]
    private float _rotationSpeed = 8f;
    [SerializeField]
    private float _shootPower = 15f;

    private int _smallestScreenDim;

    private void Start()
    {
        _rotationSpeed = _rotationSpeed / 100000;

        _smallestScreenDim = Screen.currentResolution.height < Screen.currentResolution.width
            ? Screen.currentResolution.height
            : Screen.currentResolution.width;
    }

    void Update()
    {
        if(_planet == null)
        {
            return;
        }

        transform.position = _planet.position;

        if (!_isPlanetLaunched)
        {
            _planet.velocity = Vector3.zero;
        }
    }

    public void ReceiveTouchInput(Vector2 moveInput)
    {
        _rotation.x += -moveInput.x * _rotationSpeed * _smallestScreenDim;
        _rotation.y += moveInput.y * _rotationSpeed * _smallestScreenDim;
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
