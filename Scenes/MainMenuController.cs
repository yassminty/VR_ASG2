using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("VR_ASG2 counters");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting.");
    }
}
