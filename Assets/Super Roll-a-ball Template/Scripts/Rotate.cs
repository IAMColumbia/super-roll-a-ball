using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rotate a rigidbody by a given speed. This can be used to affect the player ball.
/// If the speed is fast, you may need to change the collision detection on the rigidbody to continuous.
/// There is a good chance you want to set the rigidbdy to kinematic and turn off gravity.
/// But I'm leaving that up to the designer just in case.
/// </summary>

[RequireComponent(typeof(Rigidbody))]
public class Rotate : MonoBehaviour
{
    public Vector3 RotationSpeed = new Vector3();

    Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();  

        if (_rigidbody == null)
        {
            Debug.LogError("Rotate script requires a Rigidbody component!");
        }
    }

    void FixedUpdate()
    {
        if (_rigidbody != null)
        {
            Quaternion deltaRotation = Quaternion.Euler(RotationSpeed * Time.fixedDeltaTime);
            _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
        }
    }
}
