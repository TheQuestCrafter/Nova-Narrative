using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xzCameraRotation : MonoBehaviour
{

    [SerializeField]
    private float rotationYSensitivity = 2f;

    private float rotationXZ;

    // Update is called once per frame
    void Update()
    {
        rotationXZ -= Input.GetAxis("Mouse Y") * rotationYSensitivity;
        rotationXZ = Mathf.Clamp(rotationXZ, -60f, 60f);
        transform.localRotation = Quaternion.Euler(rotationXZ, 0, 0);
    }
}
