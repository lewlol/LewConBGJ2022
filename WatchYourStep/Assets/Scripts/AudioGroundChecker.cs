using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGroundChecker : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip land;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            audio.clip = land;
            audio.Play();
        }
    }
}
