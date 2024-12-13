using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Shubham
// 23BCG10021

public class LinearMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 25f;
    [SerializeField] private bool isAuto = false;
    private Vector3 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isAuto)
            AutoMove();
        else
            Move();
    }

    private void AutoMove()
    {
        if (!target)
        {
            Debug.LogWarning("No Target for Automatic Movement");
            return;
        }
        Vector3 direction = (target.position - transform.position).normalized;
        //rb.velocity = direction * speed * Time.deltaTime;
        transform.Translate(direction * speed * Time.deltaTime);
    } 

    private void Move()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");

        transform.Translate(movement * speed * Time.deltaTime);
        //rb.velocity = speed * Time.deltaTime * movement;
    }
}
