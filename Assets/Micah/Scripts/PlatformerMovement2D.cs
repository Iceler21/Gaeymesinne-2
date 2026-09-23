using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlatformerMovement2D : MonoBehaviour
{
    public float moveSpeed = 0f;

    public float jumpForce = 14f;
    
    

    private Rigidbody2D rb;
    private float moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        Keyboard kb = Keyboard.current;

        moveInput = 0;
        if (kb.aKey.isPressed) moveInput = -1f;
        if (kb.dKey.isPressed) moveInput = 1f;

        if (kb.spaceKey.wasPressedThisFrame) Jump();
    }

    private void Jump()
    {
        rb.linearVelocityY = jumpForce;
    }
}


// Video Time = 3:42