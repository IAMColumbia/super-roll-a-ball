using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TMP_Text textObject;

    public Color winColor;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered trigger");

        bool isPlayer = other.GetComponent<PlayerController>() != null;

        if (isPlayer)
        {
            Debug.Log("Player entered Trigger");
            textObject.color = winColor;
        }
    }
}
