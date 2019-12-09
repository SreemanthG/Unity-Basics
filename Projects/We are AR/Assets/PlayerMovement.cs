using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //rigidBody Reference - rb
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;


    //We want to update this  if physics
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce*Time.deltaTime); //Adding force 2000 on Z-axis 
            
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
    }
}
