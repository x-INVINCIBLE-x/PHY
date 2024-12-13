using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{
    private void AttachIt(Transform _transform)
    {
        transform.parent = _transform;
    }
}
