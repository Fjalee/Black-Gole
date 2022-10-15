using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempVeloctiyManager : MonoBehaviour
{
    [SerializeField]
    private int _speed;
    Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        if(_rb != null)
        {
            _rb.velocity = Vector3.forward * _speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
