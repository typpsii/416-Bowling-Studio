using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider body)
    {
        Rigidbody ballRb = body.GetComponent<Rigidbody>();
        float velocityMagnitude = ballRb.linearVelocity.magnitude;

        ballRb.linearVelocity = Vector3.zero;
        ballRb.angularVelocity = Vector3.zero;

        ballRb.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);
    }
}
