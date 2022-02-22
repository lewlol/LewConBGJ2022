using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip click;

    public GameObject playButton;
    public GameObject easyText;
    public GameObject hardText;

    public void Play()
    {
        audio.Play();
        playButton.SetActive(false);
        easyText.SetActive(true);
        hardText.SetActive(true);
    }

    public void EasyMode()
    {
        audio.Play();
        SceneManager.LoadScene(2);
    }
    public void HardMode()
    {
        audio.Play();
        SceneManager.LoadScene(2);
    }

}