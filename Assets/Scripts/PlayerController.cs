using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody rb;

    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private float turnSpeed;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private float currentVertSpeed;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }

    private void Movement()
    {
        if (Input.GetButton("Vertical"))
        {
            VerticalMovement();
        }
        MouseLook();
    }

    private void MouseLook()
    {
        
    }

    private void VerticalMovement()
    {
        float verticalVelocity = Mathf.Clamp(speed * Input.GetAxisRaw("Vertical"), -maxSpeed, maxSpeed);
        rb.AddForce(0, 0, verticalVelocity);
        currentVertSpeed = rb.velocity.z; 
    }
}
