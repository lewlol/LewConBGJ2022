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
    
    void Start()
    {
        Watch.SetActive(false);
        Your.SetActive(false);
        Step.SetActive(false);
        start.SetActive(false);
        StartCoroutine(Menu());
    }

    IEnumerator Menu()
    {
        yield return new WaitForSeconds(0.5f);
        boom.Play();
        Watch.SetActive(true);
        yield return new WaitForSeconds(1f);
        boom.Play();
        Your.SetActive(true);
        yield return new WaitForSeconds(1f);
        boom.Play();
        Step.SetActive(true);
        yield return new WaitForSeconds(1f);
        start.SetActive(true);
        intro.Play();



    }

    
}
