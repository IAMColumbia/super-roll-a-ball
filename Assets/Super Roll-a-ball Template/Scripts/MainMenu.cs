using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Be sure to put the first level in scene index 1 on the build settings!
        SceneManager.LoadScene(1);
    }
}
