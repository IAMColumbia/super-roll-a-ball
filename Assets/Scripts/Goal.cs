using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TMP_Text textObject;
    public GameObject missionCompleteCanvas;
    public Color winColor;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered trigger");

        bool isPlayer = other.GetComponent<PlayerController>() != null;

        if (isPlayer)
        {
            Debug.Log("Player entered Trigger");
            textObject.color = winColor;

            // Show the mission complete UI Canvas
            missionCompleteCanvas.SetActive(true);

            var playerController = other.GetComponent<PlayerController>();
            playerController.enabled = false;
            var rb = other.GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
        }
    }
}
