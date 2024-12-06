using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb;
    [Range(0, 1)]public float restitution = 0.9f;
    Vector3 velocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        velocity = rb.velocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;

        Vector3 newVelocity = Vector3.Reflect(velocity, normal) * restitution;
        rb.velocity = newVelocity;
    }
}
