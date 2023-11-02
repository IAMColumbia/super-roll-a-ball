using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 RotationSpeed = new Vector3();

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.rotation.eulerAngles + RotationSpeed * Time.deltaTime);
    }
}
