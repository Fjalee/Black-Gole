using UnityEngine;

public class PanoramicSlowRotation : MonoBehaviour
{
    [SerializeField]
    private float _xSpeed;
    [SerializeField]
    private float _ySpeed;
    [SerializeField]
    private float _zSpeed;

    public void Start()
    {
        _xSpeed = _xSpeed / 10000;
        _ySpeed = _ySpeed / 10000;
        _zSpeed = _zSpeed / 10000;
    }

    public void Update()
    {
        transform.Rotate(new Vector3(_xSpeed, _ySpeed, _zSpeed));
    }
}
