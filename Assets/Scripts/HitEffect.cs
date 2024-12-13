using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    public GameObject[] hitEffect;

    private void OnCollisionEnter(Collision collision)
    {
        foreach (GameObject newEffect in hitEffect)
        {
            GameObject effect = Instantiate(newEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
        }
    }
}
