using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundOver : MonoBehaviour
{
    public float forceRadius = 1.0f;

    void OnCollisionEnter()
    {
        foreach (Collider collider in Physics.OverlapSphere(transform.position, forceRadius))
        {
            SceneManager.LoadScene("_End_Scene");
        }
    }
    
}
