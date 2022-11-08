using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class InputManager : MonoBehaviour
{
    [SerializeField] private ControlPoint _controlPoint;

    private PlanetControls.BasicActions _basicActions;

    private PlanetControls _controls;

    private Vector2 _touchInput;

    private void Awake()
    {
        _controls = new PlanetControls();
        _basicActions = _controls.Basic;

        EnhancedTouchSupport.Enable();

        _basicActions.TouchX.performed += context => _touchInput.x = context.ReadValue<float>();
        _basicActions.TouchY.performed += context => _touchInput.y = context.ReadValue<float>();
        Touch.onFingerDown += _controlPoint.OnFingerDown;
        Touch.onFingerUp += _controlPoint.OnFingerUp;
    }

    private void Update()
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
