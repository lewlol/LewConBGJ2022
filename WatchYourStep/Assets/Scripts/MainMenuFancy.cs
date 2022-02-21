using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFancy : MonoBehaviour
{
    public AudioSource boom;
    public GameObject Watch;
    public GameObject Your;
    public GameObject Step;
    public GameObject start;
    public GameObject quit; 
    
    void Start()
    {
        Watch.SetActive(false);
        Your.SetActive(false);
        Step.SetActive(false);
        start.SetActive(false);
        quit.SetActive(false);
        StartCoroutine(Menu());
    }

    IEnumerator Menu()
    {
        boom.Play();
        Watch.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        boom.Play();
        Your.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        boom.Play();
        Step.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        start.SetActive(true);
        quit.SetActive(true);
        


    }

    
}
