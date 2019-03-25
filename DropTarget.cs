using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTarget : MonoBehaviour
{
    public float dropDistance = 1.0f;
    public int bankID = 0;
    public float resetDelay = 0.5f;
    public static List<DropTarget> dropTargets = new List<DropTarget>();

    public int targetValue = 100;
    public int bankValue = 5000;
    public bool isDropped = false;

    // Start is called before the first frame update
    void start()
    {
        dropTargets.Add(this);
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter()
    {
        if (!isDropped)
        {
            //Drop target
            transform.position += Vector3.down * dropDistance;
            isDropped = true;
            ScoreManager.score += targetValue;

            //Check to see if the rest of the bank has been dropped
            bool resetBank = true;
            foreach (DropTarget target in dropTargets)
            {
                if (target.bankID == bankID)
                {
                    if (!target.isDropped)
                    {
                        resetBank = false;
                    }
                }
            }

            if (resetBank)
            {
                //ScoreManager.score += targetValue;
                Invoke("ResetBank", resetDelay);
            }
        }
    }
}
