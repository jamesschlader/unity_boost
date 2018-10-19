using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float mainThrust = 100f;

    Rigidbody rigidBody;

    public AudioSource audioSource { get; private set; }

    private AudioClip audioRocket;

    public bool freezeRotation;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
       
        Rotate();
        Thrust();
    }

    private void Rotate()
    {

        rigidBody.freezeRotation = true;

        
        float rotationThisFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
           

            print("Going right");
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            print("Going left");
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        rigidBody.freezeRotation = false;
    }

    private void Thrust()
    {

        float giveMoreThrust = mainThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            print("Trust!");
            rigidBody.AddRelativeForce(Vector3.down * giveMoreThrust);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }

        }
        else
        {
            audioSource.Stop();
        }
    }
}
