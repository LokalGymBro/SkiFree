using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkierController : MonoBehaviour
{
    public float moveSpeed = 10f; // Speed of the skier
    public float turnSpeed = 5f; // Speed of turning

    private Rigidbody skierRigidbody;

    void Start()
    {
        // Get the Rigidbody component attached to the skier GameObject
        skierRigidbody = GetComponent<Rigidbody>();

        skierRigidbody = GetComponent<Rigidbody>();
    }
    

    void FixedUpdate()
    {
        // Move the skier forward based on moveSpeed
        skierRigidbody.velocity = transform.forward * moveSpeed;

        // Calculate horizontal input for turning
        float horizontalInput = Input.GetAxis("Horizontal");

        // Adjust horizontal input based on 'A' and 'D' keys for keyboard input
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }

        // Rotate the skier based on turnSpeed and horizontal input
        Quaternion turnRotation = Quaternion.Euler(0f, horizontalInput * turnSpeed, 0f);
        skierRigidbody.MoveRotation(skierRigidbody.rotation * turnRotation);
    }
}
