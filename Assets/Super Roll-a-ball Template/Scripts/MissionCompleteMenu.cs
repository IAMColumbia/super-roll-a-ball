using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionCompleteMenu : MonoBehaviour
{
   public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        // Must put main menu scene as scene 0 in the build settings!
        SceneManager.LoadScene(0);
    }
 
}
