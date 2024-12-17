using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{
    private bool attatched = false;
    private Transform target = null;
    public void AttachIt(Transform _transform)
    {
        attatched = true;
        target = _transform;
    }

    private void Update()
    {
        if (target)
        {
            transform.localPosition = target.localPosition;
        }
    }
}
