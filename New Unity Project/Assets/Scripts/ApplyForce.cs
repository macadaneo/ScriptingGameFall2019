using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 forces;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(0,30f,0);
    }
}
