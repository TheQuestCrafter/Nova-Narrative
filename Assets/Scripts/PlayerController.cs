using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody rb;
    private Vector3 movementVertical;
    private Vector3 movementHorizontal;
    private float jumpTimeCheck;

    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private float maxSpeed;
    [SerializeField]
    private GameObject childOne;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private float jumpCoolDown = 5;

    [SerializeField]
    float currentMagnitude;
    [SerializeField]
    float movementX;
    [SerializeField]
    float movementY;
    [SerializeField]
    float movementZ;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpTimeCheck = Time.time;
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
            movementVertical = childOne.transform.forward * Input.GetAxisRaw("Vertical");
            rb.AddForce(movementVertical.normalized * speed);
        }
        if (Input.GetButton("Horizontal"))
        {
            movementHorizontal = childOne.transform.right * Input.GetAxisRaw("Horizontal");
            rb.AddForce(movementHorizontal.normalized * speed);
        }
        if (Input.GetButton("Jump") && (Time.time > (jumpTimeCheck + jumpCoolDown)))
        {
            jumpTimeCheck = Time.time;
            rb.AddForce(0, jumpForce, 0);
        }
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        VectorDiagnostic();
        
    }

    private void VectorDiagnostic()
    {
        movementX = rb.velocity.x;
        movementY = rb.velocity.y;
        movementZ = rb.velocity.z;
        currentMagnitude = rb.velocity.magnitude;
    }
}
