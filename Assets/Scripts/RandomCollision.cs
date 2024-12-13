using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollision : MonoBehaviour
{
    public float minRange = 1f;
    public float maxRange = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            float x = Random.Range(minRange, maxRange);
            float z = Random.Range(minRange, maxRange);

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(x, 0, z, ForceMode.Impulse);
        }
    }
}
