using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject playButton;
    public GameObject quitButton;
    public GameObject easyText;
    public GameObject hardText;

    public void Play()
    {
        playButton.SetActive(false);
        quitButton.SetActive(false);
        easyText.SetActive(true);
        hardText.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void EasyMode()
    {
        SceneManager.LoadScene(2);
    }
    public void HardMode()
    {
        SceneManager.LoadScene(2);
    }

}