using UnityEngine;

public class Cible : MonoBehaviour
{
    [Header("Vie")]
    public int life = 10;

    [Header("Tremblement")]
    public float shakeIntensity = 0.05f;
    public float shakeDuration = 0.2f;

    private Vector3 basePosition;
    private float shakeTimer;

    void Start()
    {
        basePosition = transform.localPosition;
    }

    void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;
            transform.localPosition = basePosition + Random.insideUnitSphere * shakeIntensity;
        }
        else
        {
            transform.localPosition = basePosition;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            Damage(1);
        }
    }

    void Damage(int amount)
    {
        life -= amount;
        shakeTimer = shakeDuration;

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
