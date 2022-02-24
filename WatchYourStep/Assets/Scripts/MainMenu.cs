using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject playButton;

    public Animator anim;

    public GameObject text1;
    public GameObject text2;
    public Text text1menu;
    public Text text2menu;
    public GameObject skiptext;

    public GameObject menuplayer;

    public void Play()
    {
        anim.SetBool("ChangingScene", true);
        StartCoroutine(ChangeToLevel());
        menuplayer.GetComponent<PlayerMovement>().enabled = false;
    }

    IEnumerator ChangeToLevel()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level");
        }

        yield return new WaitForSeconds(2f);
        text1.SetActive(true);
        yield return new WaitForSeconds(5f);
        skiptext.SetActive(true);
        yield return new WaitForSeconds(8f);
        text2.SetActive(true);
        yield return new WaitForSeconds(5f);
        text1.SetActive(false);
        text2.SetActive(false);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Level");
    }

    private void Update()
    {
    

    }
}