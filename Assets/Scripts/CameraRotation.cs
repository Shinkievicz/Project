using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float yRotation;
    public float xRotation;
    public float lookSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            xRotation -= Input.GetAxis("Mouse Y")* lookSpeed;
            yRotation += Input.GetAxis("Mouse X") * lookSpeed;

            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        }
    }
}
