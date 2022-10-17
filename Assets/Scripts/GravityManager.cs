using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    //[SerializeField]
    private float _pullRadiusFromCenter = 20000;    //20000 temporary, all object should be pulled

    [SerializeField]
    private float _gravitationalConstant;
    private int _gravityAffectedMask = (1 << 6); // 6th layer is GravityAffected

    public void FixedUpdate()
    {
        ApplyGravityToObjectsAround();
    }

    private void ApplyGravityToObjectsAround()
    {
        var collidersInsidePullRadius = Physics.OverlapSphere(transform.position, _pullRadiusFromCenter, _gravityAffectedMask);
        foreach (var pulledCollider in collidersInsidePullRadius)
        {
            // calculate direction from target to me
            var forceDirection = transform.position - pulledCollider.transform.position;

            var distanceBetweenCenters = Vector3.Distance(pulledCollider.transform.position, gameObject.transform.position);

            var massPulledObject = pulledCollider.GetComponent<Rigidbody>().mass;
            var massThisObject = gameObject.GetComponent<Rigidbody>().mass;

            var forceToApply = (_gravitationalConstant * massThisObject * massPulledObject) / Math.Pow(distanceBetweenCenters, 2);

            // apply force on target towards me
            pulledCollider.attachedRigidbody.AddForce((float)forceToApply * forceDirection.normalized * Time.fixedDeltaTime);
        }
    }
}
