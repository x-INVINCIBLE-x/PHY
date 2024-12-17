using UnityEngine;

public class BallasticPendulum : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f;
    public float targetAngle = 0f;
    public float startAngle = -90f;
    public bool startSwing;
    public BallasticPendulum otherPendulum;

    public Transform joint;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, startAngle);
    }

    private void Update()
    {
        if (startSwing == false) return;

        float currentZAngle = transform.eulerAngles.z;
        if (currentZAngle > 180f) currentZAngle -= 360f;

        float newZAngle = Mathf.MoveTowards(currentZAngle, targetAngle, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0f, 0f, newZAngle);

        if (transform.rotation == Quaternion.Euler(0f, 0f, targetAngle))
        {
            //if (targetAngle == 0)
            //{
            //    otherPendulum.startSwing = true;
            //    startSwing = false;
            //}
           (startAngle, targetAngle) = (targetAngle, startAngle); 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.TryGetComponent(out Attach attach))
        {
            collision.transform.parent = joint;
            joint.localPosition = Vector3.zero;
        }
    }
}