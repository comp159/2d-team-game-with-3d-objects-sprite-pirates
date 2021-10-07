using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public void SwitchToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame() //this will not work in the editor
    {
        Application.Quit();
    }
}
