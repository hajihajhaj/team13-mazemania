using UnityEngine;

public class WindTrailController : MonoBehaviour
{
    private TrailRenderer trail;
    private Rigidbody rb;

    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Increase trail length with speed
        trail.time = Mathf.Clamp(rb.velocity.magnitude * 0.1f, 0.2f, 1f);
    }
}
