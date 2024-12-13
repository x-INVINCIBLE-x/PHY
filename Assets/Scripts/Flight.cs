using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flight : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed = 25f;
    private Vector3 movement;

    private void Update()
    {
        AutoMove();
    }

    private void AutoMove()
    {
        if (!target)
        {
            Debug.LogWarning("No Target for Automatic Movement");
            return;
        }
        Vector3 direction = (target.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
