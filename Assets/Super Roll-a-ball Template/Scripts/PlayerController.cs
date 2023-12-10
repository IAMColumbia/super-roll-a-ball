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
       // Debug.Log("OnMove called!" + moveInputVector);
    }

    private void FixedUpdate()
    {
        var movementInput = new Vector3(moveInputVector.x, 0, moveInputVector.y);
        var camRotationFlattened = Quaternion.LookRotation(Camera.main.transform.forward);
        var cameraRelativeInput = camRotationFlattened * movementInput;

        Vector3 force = new Vector3(cameraRelativeInput.x * speed, 0, cameraRelativeInput.z * speed);
        rb.AddForce(force);        
    }

}