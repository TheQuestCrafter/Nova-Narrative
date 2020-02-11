using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{    
    [SerializeField]
    private float rotationXSensitivity = 3f;

    private float rotationYAxis;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotationYAxis += Input.GetAxis("Mouse X") * rotationXSensitivity;
        transform.localRotation = Quaternion.Euler(0, rotationYAxis, 0);
    }
}
