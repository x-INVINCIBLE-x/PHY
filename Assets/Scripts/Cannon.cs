using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonballPrefab; 
    public Transform firePoint;         
    public float launchSpeed = 20f;     
    public RotateObject rotateObject;   

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }

    void FireCannon()
    {
        GameObject cannonball = Instantiate(cannonballPrefab, firePoint.position, Quaternion.identity);

        Rigidbody rb = cannonball.GetComponent<Rigidbody>();

        if (rb != null && rotateObject != null)
        {
            //float angleInRadians = rotateObject.TargetZRotation * Mathf.Deg2Rad;

            //Vector3 launchDirection = new Vector3(Mathf.Cos(angleInRadians), Mathf.Sin(angleInRadians), 0);

            //rb.velocity = launchDirection * launchSpeed;

            rb.velocity = transform.right * launchSpeed;
        }
    }
}
