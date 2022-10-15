using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    [SerializeField]
    private float _pullRadiusFromCenter;

    [SerializeField]
    private float _pullForce;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FixedUpdate()
    {
        var collidersInsidePullRadius = Physics.OverlapSphere(transform.position, _pullRadiusFromCenter);
        foreach (var collider in collidersInsidePullRadius)
        {
            // calculate direction from target to me
            Vector3 forceDirection = transform.position - collider.transform.position;

            // apply force on target towards me
            collider.attachedRigidbody.AddForce(forceDirection.normalized * _pullForce * Time.fixedDeltaTime);
        }
    }
}
