using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        player = Camera.main.transform;
    }

    void Update()
    {
        LookAtPlayer();
    }

    void LookAtPlayer()
    {
        Vector3 direction = player.position - transform.position;
        direction.y = 0; // empêche de regarder vers le haut/bas
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
