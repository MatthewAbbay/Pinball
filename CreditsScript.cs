using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    private float myTimeout;
    // Start is called before the first frame update
    void Start()
    {
        myTimeout = 3 + Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > myTimeout)
        {
            SceneManager.LoadScene("_Start_Scene");
        }
    }
}
