using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AutoMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private int dir;
    public bool hit = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (hit == false)
        {
            rb.velocity = new Vector3(0, 0, speed * dir * Time.deltaTime);
        }
        else
            rb.velocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            hit = true;
            rb.velocity = Vector3.zero;
        }
    }
}
