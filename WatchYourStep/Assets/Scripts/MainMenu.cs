using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject playButton;
    public GameObject easyText;
    public GameObject hardText;

    public Animator anim;

    private void Awake()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
    public void Play()
    {
        playButton.SetActive(false);
        easyText.SetActive(true);
        hardText.SetActive(true);
    }

    public void EasyMode()
    {
        Debug.Log("Enter In Easy Mode");
    }
    public void HardMode()
    {
        Debug.Log("Enter In Hard Mode");
        anim.SetBool("ChangingScene", true);
        StartCoroutine(ChangeToLevel());
    }

    IEnumerator ChangeToLevel()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level");
    }

}