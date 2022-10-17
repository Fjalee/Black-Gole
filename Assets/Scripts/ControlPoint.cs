using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    private float _xRotation, _yRotation = 0;

    private bool _isPlanetLaunched = false;

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
    }

    public void ReceiveTouchInput(Vector2 moveInput)
    {
        _xRotation += moveInput.x * _rotationSpeedX;
        _yRotation += moveInput.y * _rotationSpeedY;
        transform.rotation = Quaternion.Euler(_yRotation, _xRotation, 0f);
    }

    public void ShootPlanet()
    {
        if (!_isPlanetLaunched)
        {
            _planet.velocity = transform.forward * _shootPower;
            _isPlanetLaunched = true;
        }
    }
}
