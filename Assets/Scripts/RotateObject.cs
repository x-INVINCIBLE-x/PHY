using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50f; 
    private float targetZRotation = 0f;
    private float targetYRotation = 0f;
    public float rotationStep = 5f;

    public float TargetZRotation => targetZRotation;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            targetZRotation = Mathf.Clamp(targetZRotation - rotationStep, 0f, 180f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            targetZRotation = Mathf.Clamp(targetZRotation + rotationStep, 0f, 180f);
        }

        float currentZRotation = Mathf.LerpAngle(transform.eulerAngles.z, targetZRotation, Time.deltaTime * rotationSpeed);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentZRotation);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            targetYRotation = Mathf.Clamp(targetYRotation - rotationStep, -180f, 180f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            targetYRotation = Mathf.Clamp(targetYRotation + rotationStep, -180f, 180f);
        }

        float currentYRotation = Mathf.LerpAngle(transform.eulerAngles.z, targetYRotation, Time.deltaTime * rotationSpeed);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, currentYRotation, transform.eulerAngles.z);
    }
}
