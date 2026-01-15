using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [Header("Input")]
    public InputActionReference shootAction;

    [Header("Projectile")]
    public GameObject projectilePrefab;

    void OnEnable()
    {
        shootAction.action.Enable();
    }

    void OnDisable()
    {
        shootAction.action.Disable();
    }

    void Update()
    {
        if (shootAction.action.WasPressedThisFrame())
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(
            projectilePrefab,
            transform.position,
            transform.rotation
        );
    }
}
