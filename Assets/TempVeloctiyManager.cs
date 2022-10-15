using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempVeloctiyManager : MonoBehaviour
{
    Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        if(_rb != null)
        {
            _rb.velocity = Vector3.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
