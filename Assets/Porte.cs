using Unity.Mathematics;
using UnityEngine;

public class Porte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    public bool opened;
    public Transform pivot;
    public Transform closedReference;
    public Transform openedReference;
    public float rotationSpeed = 2f;
    void Update()
    {
        Quaternion targetRotation = opened
            ? openedReference.localRotation
            : closedReference.localRotation;

        pivot.localRotation = Quaternion.Slerp(
            pivot.localRotation,
            targetRotation,
            Time.deltaTime * rotationSpeed
        );
    }

    public void Open()
    {
        opened = true;
    }

    public void Close()
    {
        opened = false;
    }

    
}
