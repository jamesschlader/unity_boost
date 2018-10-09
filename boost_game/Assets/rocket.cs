using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

    Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
	}

    private void ProcessInput()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            print("Trust!");
            rigidBody.AddRelativeForce(Vector3.down);

        }

        if (Input.GetKey(KeyCode.D))
        {
            print("Going right");
        } else if (Input.GetKey(KeyCode.A))
        {
            print("Going left");
        }

    }
}
