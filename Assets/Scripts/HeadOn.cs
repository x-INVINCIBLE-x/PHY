using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HeadOn : MonoBehaviour
{
    public float speed;
    public float dir;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody>().AddForce(0, 0, speed * dir, ForceMode.Impulse);
    }
}
