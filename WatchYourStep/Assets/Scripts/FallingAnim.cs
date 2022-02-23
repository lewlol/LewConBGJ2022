using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingAnim : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite fall;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            sr.sprite = fall;
        }
    }
}
