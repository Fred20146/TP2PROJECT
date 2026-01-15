using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody rb;
    public float launchForce = 10f;

    void Start()
    {
        rb.AddForce(transform.forward * launchForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Projectile a touché : " + collision.gameObject.name);
    }
}
