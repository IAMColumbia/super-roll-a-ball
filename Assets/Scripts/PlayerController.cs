using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody rb;
    Vector2 moveInputVector;

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInputVector = context.ReadValue<Vector2>();
        Debug.Log("OnMove called!" + moveInputVector);
    }

    private void FixedUpdate()
    {
        Vector3 force = new Vector3(moveInputVector.x * speed, 0, moveInputVector.y * speed);
        rb.AddForce(force);        
    }
}
