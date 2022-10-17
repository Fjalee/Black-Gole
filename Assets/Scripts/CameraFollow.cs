using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _speed = 15f;

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, _target.rotation, _speed * Time.deltaTime);
    }
}
