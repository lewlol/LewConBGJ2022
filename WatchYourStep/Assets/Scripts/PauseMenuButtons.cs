using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuButtons : MonoBehaviour
{
    public void restartscene()
    {
        SceneManager.LoadScene("Level");
    }

    public void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }




}
