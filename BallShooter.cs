using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour
{
    public float force;
    List<Rigidbody> ballList;

    // Start is called before the first frame update
    void Start()
    {
        ballList = new List<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.Space))
        {
            foreach (Rigidbody ball in ballList)
            {
                ball.AddForce(Vector3.forward * force);
            }
        }
      
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<Rigidbody>())
        {
            Debug.Log("Object has Rigidbody");
            ballList.Add(collider.GetComponent<Rigidbody>());
        }
     
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.GetComponent<Rigidbody>())
        {
            Debug.Log("Object has Rigidbody");
            ballList.Remove(collider.GetComponent<Rigidbody>());
        }
    }
}
