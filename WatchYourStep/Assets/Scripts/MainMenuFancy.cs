using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFancy : MonoBehaviour
{
    public AudioSource intro;
    public AudioSource boom;
    public GameObject Watch;
    public GameObject Your;
    public GameObject Step;
    public GameObject start;

    public GameObject particles1;
    public GameObject particles2;
    public GameObject particles3;

    void Awake()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        Watch.SetActive(false);
        Your.SetActive(false);
        Step.SetActive(false);
        start.SetActive(false);
        StartCoroutine(Menu());
        Cursor.lockState = CursorLockMode.None;
    }

    IEnumerator Menu()
    {
        Debug.Log("Obama Bin Swaggin!");
        yield return new WaitForSeconds(0.5f);
        boom.Play();
        Watch.SetActive(true);
        particles1.SetActive(true);
        yield return new WaitForSeconds(1f);
        boom.Play();
        Your.SetActive(true);
        particles2.SetActive(true);
        yield return new WaitForSeconds(1f);
        boom.Play();
        Step.SetActive(true);
        particles3.SetActive(true);
        yield return new WaitForSeconds(1f);
        start.SetActive(true);
        intro.Play();



    }

    
}
