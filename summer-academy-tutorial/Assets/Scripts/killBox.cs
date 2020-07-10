using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBox : MonoBehaviour
{
    //this script will destroy any game objects that move into it.
    //check if there is an event that triggers

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter trigger");

        //check if object is tagged enemy
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            Debug.Log("enemy detected");
            Debug.Log("hi rob");
        }
    }
    //destroy the object


}
