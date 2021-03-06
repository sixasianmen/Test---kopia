﻿using UnityEngine;

public class PlayerMove : MonoBehaviour {

    // This is a reference to the component Rigidbody called Rb
    public Rigidbody Rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

	// Here I use "Fixed"Update because I'm dealing with physics
	// Update is called once per frame
	void FixedUpdate()   
    {
        // add a forward force
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);   

        // movement to the sides
        if ( Input.GetKey("d") )
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKey("a") )
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}

public class PlayerCollide : MonoBehaviour {

    //referance to first script
    public PlayerMove movement;

    //Player collision script
    void OnCollisionEnter (UnityEngine.Collision collisioninfo)
    {
        if ( collisioninfo.gameObject.tag == "Obstacle" )
        {
            Debug.Log("We hit an obstacle!");
        }
    }
}
