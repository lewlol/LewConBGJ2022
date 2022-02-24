using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndToMenu : MonoBehaviour
{
    public Animator reachTop;
    public Animator timeTook;
    public Animator jumpTaken;
    public Animator coinsCollected;
    public Animator clickToMenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(ToMenu());
        }
            
            

        
    }
    IEnumerator ToMenu()
    {
        reachTop.SetBool("menu", true);
        timeTook.SetBool("menu1", true);
        jumpTaken.SetBool("menu2", true);
        coinsCollected.SetBool("menu3", true);
        clickToMenu.SetBool("menu4", true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainMenu");
    }
}
