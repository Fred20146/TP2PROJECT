using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    public InputActionReference Touche;

    private void OnEnable()
    {
        Touche.action.Enable();
        Touche.action.performed += OnTouchePressed;
    }

    private void OnDisable()
    {
        Touche.action.Disable();
        Touche.action.performed -= OnTouchePressed;
    }

    // void Update()
    // {
        
    // }

    void OnTouchePressed(InputAction.CallbackContext obj)
    {
        print("GOOD !");
    }
}
