using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        LateralMovement();
        
    }


    void LateralMovement()
    {
        float adjustedSpeed = speed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            adjustedSpeed *= 2;
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * adjustedSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * adjustedSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * adjustedSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * adjustedSpeed * Time.deltaTime, Space.World);
        }
    }
}
