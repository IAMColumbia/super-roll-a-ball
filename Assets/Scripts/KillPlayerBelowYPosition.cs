using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayerBelowYPosition : MonoBehaviour
{

    GameObject player;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerController>().gameObject;
    }

    void Update()
    {
        if (player.transform.position.y < this.transform.position.y )
        {
            // TODO: respawn player. Maybe in the future this means a game over screen or
            // some kind of checkpoint system

            // restart the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
