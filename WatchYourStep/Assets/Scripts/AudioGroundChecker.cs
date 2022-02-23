using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioGroundChecker : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip land;
    public SpriteRenderer sr;
    public Sprite ground;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground")
        {
            sr.sprite = ground;
            audio.clip = land;
            audio.Play();
        }
    }
}
