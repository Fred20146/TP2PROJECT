using UnityEngine;

public class Cible : MonoBehaviour
{
    [Header("Vie")]
    public int life = 10;

    private void OnCollisionEnter(Collision collision)
    {
        print("Collision");
    }
}

