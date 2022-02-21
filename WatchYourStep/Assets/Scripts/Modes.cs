using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modes : MonoBehaviour
{
    public void EasyMode()
    {
        SceneManager.LoadScene(2);
        //enable easy disable hard
    }

    public void HardMode()
    {
        SceneManager.LoadScene(2);
        //enable hard disable easy
    }
}
