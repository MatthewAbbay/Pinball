using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bumper : MonoBehaviour
{
    public float force = 100.0f;
    public float forceRadius = 1.0f;
    public int scoreValue = 50;
    public AudioSource ding;
    
    void OnCollisionEnter()
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, forceRadius))
        {
            if (collider.GetComponent<Rigidbody>())
            {
                collider.attachedRigidbody.AddExplosionForce(force, transform.position, forceRadius);
            }
        }

        ScoreManager.score += scoreValue;
        ding.Play();
    }
}
