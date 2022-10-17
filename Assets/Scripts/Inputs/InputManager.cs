using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private ControlPoint _controlPoint;
    
    private PlanetControls _controls;

    private PlanetControls.BasicActions _basicActions;

    private Vector2 _touchInput;

    private void Awake()
    {
        _controls = new PlanetControls();
        _basicActions = _controls.Basic;

        _basicActions.TouchX.performed += context => _touchInput.x = context.ReadValue<float>();
        _basicActions.TouchY.performed += context => _touchInput.y = context.ReadValue<float>();
        _basicActions.Shoot.performed += _ => _controlPoint.ShootPlanet();
    }

    void Update()
    {
        _controlPoint.ReceiveTouchInput(_touchInput);
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDestroy()
    {
        _controls.Disable();
    }
}
