using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GenericTrigger : MonoBehaviour
{
    public bool onlyTriggerOnce = false;
    public UnityEvent OnTriggerEntered;

    private bool _hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered trigger");

        bool isPlayer = other.GetComponent<PlayerController>() != null;

        if (isPlayer)
        {
            Debug.Log("Player entered Trigger");
            if (!_hasTriggered || !onlyTriggerOnce)
            {
                OnTriggerEntered?.Invoke();
                _hasTriggered = true;
            }
        }
    }
}
