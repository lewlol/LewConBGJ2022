using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimer : MonoBehaviour
{
    public GameObject timer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        timer.SendMessage("finish");
    }

}
