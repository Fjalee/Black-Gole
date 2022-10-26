using UnityEngine;

public class PanoramicSlowRotation : MonoBehaviour
{
    [SerializeField]
    private float _xSpeed;
    [SerializeField]
    private float _ySpeed;
    [SerializeField]
    private float _zSpeed;

    public void Update()
    {
        transform.Rotate(new Vector3(_xSpeed, _ySpeed, _zSpeed));
    }
}
