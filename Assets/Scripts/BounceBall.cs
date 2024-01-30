using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BounceBall : MonoBehaviour
{
   [SerializeField] float force = 10f; // force power
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BounceTheBall();
        }
    }

    void BounceTheBall()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // add force on the ball in an upward direction
        rb.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}

