using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public SpriteRenderer cointing;
    public GameObject cointrigger;
    public static float coinscollected;
    public AudioSource coinsound;

    private void Start()
    {
        coinscollected = 0;
    }

    IEnumerator Pickupcoin()
    { 
        cointing.enabled = false;    
        coinsound.Play();
        yield return new WaitForSeconds(0.0001f);
        cointrigger.SetActive(false);
        coinscollected += 1;


    }
    



    private void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(Pickupcoin());
    }


}
