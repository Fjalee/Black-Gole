using System;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class ControlPoint : MonoBehaviour
{
    [SerializeField] private Rigidbody _planet;

    [SerializeField] private float _rotationSpeed = 8f;

    [SerializeField] private float _maxShootPower = 30f;

    [SerializeField] private double _maxChargeTime = 3f;

    private double? _chargeStartTime;

    private bool _isPlanetLaunched;
    private Vector2 _rotation = Vector2.zero;

    private int _smallestScreenDim;

    private void Start()
    {
        _rotationSpeed = _rotationSpeed / 100000;

        _smallestScreenDim = Screen.currentResolution.height < Screen.currentResolution.width
            ? Screen.currentResolution.height
            : Screen.currentResolution.width;
    }

    private void Update()
    {
        if(_planet == null)
        {
            return;
        }

        transform.position = _planet.position;

        if (!_isPlanetLaunched) _planet.velocity = Vector3.zero;
    }

    public void ReceiveTouchInput(Vector2 moveInput)
    {
        if (_chargeStartTime != null)
        {
            return;
        }

        _rotation.x += -moveInput.x * _rotationSpeed * _smallestScreenDim;
        _rotation.y += moveInput.y * _rotationSpeed * _smallestScreenDim;
        transform.rotation = Quaternion.Euler(_rotation.y, _rotation.x, 0f);
    }

    private bool IsFingerOnPlanetBall(Vector2 touchPosition)
    {
        var ray = Camera.main.ScreenPointToRay(touchPosition);

        return Physics.Raycast(ray, out var hit) && hit.collider.CompareTag("PlanetBall");
    }

    public void OnFingerDown(Finger finger)
    {
        if (_isPlanetLaunched)
        {
            return;
        }

        _chargeStartTime = IsFingerOnPlanetBall(finger.screenPosition) ? finger.currentTouch.time : null;
    }

    public void OnFingerUp(Finger finger)
    {
        if (_chargeStartTime == null || _isPlanetLaunched || !IsFingerOnPlanetBall(finger.screenPosition))
        {
            return;
        }

        var chargeModifier = (float)(Math.Min(finger.currentTouch.time - (_chargeStartTime ?? 0), _maxChargeTime) / _maxChargeTime);

        _planet.velocity = transform.forward * _maxShootPower * chargeModifier;
        _isPlanetLaunched = true;
        _chargeStartTime = null;
    }
}
