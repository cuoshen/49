using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody rb;

    public float Speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space hit");
        }
        Debug.Log("Update");
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(mH * Speed, rb.velocity.y, mV * Speed);
    }
}