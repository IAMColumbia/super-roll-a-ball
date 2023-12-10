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

            // Stop the player from moving
            rb.velocity = Vector3.zero;

            // I actually don't like stopping it right away
            // or it doesn't roll into the goal.
            // Need to think about best solution.
            // Maybe just add invisible collision to goal.
            // Maybe disable the respawn on falling below Y functionality.
        
            //rb.angularDrag = 100;
        }
    }
}
