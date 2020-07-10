using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    //first identify a rigid body that will be moved
    public Rigidbody rb;
    public Vector3 movement;
    public float power;
    //public/private, obj variable that you are using, variable name
   
    //input types:
     //float 1.555f
     //int 1
     //string "series of characters in quotation marks"
     //bool true/false
     //GameObjects
      

    //need to move the rigid body towards the opposite side of the platform

    //private vs public
    //void = function
    //name function "Update" (variable or obj)

    private void Update()
        //{
    {
       
        //AddForce uses a Vecotr3(x,y,z)
        rb.AddForce(movement * power);
   
    }


}
