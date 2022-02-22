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

    public void Play()
    {
        playButton.SetActive(false);
        easyText.SetActive(true);
        hardText.SetActive(true);
    }

    public void EasyMode()
    {
        anim.SetBool("ChangingScene", true);
        StartCoroutine(ChangeToLevel());
    }
    public void HardMode()
    {
        anim.SetBool("ChangingScene", true);
        SceneManager.LoadScene(2);
    }

    IEnumerator ChangeToLevel()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
    }

}