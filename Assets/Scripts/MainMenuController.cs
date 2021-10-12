using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject StartButton;
    [SerializeField] private GameObject QuitButton;
    [SerializeField] private GameObject StartText;
    [SerializeField] private GameObject Light;
    public void SwitchToGame()
    {
        //Credit to this forum for showing some code to resolve the lighting issue:
        //https://forum.unity.com/threads/loading-scene-additively-causes-change-in-lighting.511566/
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
        StartButton.SetActive(false);
        QuitButton.SetActive(false);
        StartText.SetActive(false);
        Light.SetActive(false);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName("SampleScene"));

    }

    public void QuitGame() //this will not work in the editor
    {
        Application.Quit();
    }
}
