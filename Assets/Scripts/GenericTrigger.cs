using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GenericTrigger : MonoBehaviour
{
    public UnityEvent OnTriggerEntered;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered trigger");

        bool isPlayer = other.GetComponent<PlayerController>() != null;

        if (isPlayer)
        {
            Debug.Log("Player entered Trigger");
            OnTriggerEntered?.Invoke();
        }
    }
}
