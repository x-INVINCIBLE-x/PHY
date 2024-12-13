using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class CollisionMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float mass;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.mass = mass;
        rb.velocity = speed * transform.right;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "Player") return;

        if (collision.transform.TryGetComponent(out Rigidbody r))
        {
            if (r.mass == rb.mass)
            {
                r.velocity = speed * Vector3.right;
                rb.velocity = Vector3.zero;
                rb.freezeRotation = true;
            }
            else if (r.mass < rb.mass)
            {
                r.velocity = speed * 1.1f * Vector3.right;
                rb.velocity = rb.velocity / 3;
            }
            else
            {
                rb.velocity = speed * -Vector3.right;
                r.velocity = Vector3.zero;
            }
        }
    }
}
