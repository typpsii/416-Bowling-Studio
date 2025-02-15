using Unity.VisualScripting;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Transform ballAnchor;
    [SerializeField] private Transform launchIndicator;

    private Rigidbody rb;
    private bool isBallLaunched;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);

        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;
        rb.isKinematic = true;
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;
        isBallLaunched = true;
        transform.parent = null;
        rb.isKinematic = false;
        rb.AddForce(launchIndicator.forward * force, ForceMode.Impulse);
        launchIndicator.gameObject.SetActive(false);
    }
}
