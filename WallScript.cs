using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public float force = 100.0f;
    public float forceRadius = 1.0f;

    void OnCollisionEnter()
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, forceRadius))
        {
            if (collider.GetComponent<Rigidbody>())
            {
                collider.attachedRigidbody.AddExplosionForce(force, transform.position, forceRadius);
            }
        }
    }
}
