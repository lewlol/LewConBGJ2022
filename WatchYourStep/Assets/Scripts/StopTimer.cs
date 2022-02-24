using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UI;

public class StopTimer : MonoBehaviour
{
    public GameObject timer;
    public Canvas barsandtings;
    public Animator fade;
    public GameObject fadeout;
    public GameObject Congrats;
    public GameObject Timetaken;
    public GameObject JumpsDone;
    public GameObject CoinsCollected;
    public GameObject ExitScene;
    public Text TotalJumps;
    public Text Totaltime;
    public Animator crown;
    public SpriteRenderer crownobj;
    public GameObject explode;
    public AudioClip explosion;
    public AudioSource Music;
    public GameObject notreal;
    public GameObject endbutton;
    public Text coins;
    public Text coinscollectedfinal;


    public void Start()
    {
        endbutton.SetActive(false); 
    }

    private void Update()
    {
        coins.text = ("Coins Collected:" + Collectable.coinscollected);
    }

    IEnumerator Endsceneswag()
    {
        TotalJumps.text = ("You jumped a total of: " + PlayerMovement.jumpCount + " times during your run");
        Totaltime.text = ("You took " + Stopwatch.minutesfinal + ":" + Stopwatch.secondsfinal + " to reach the top of the tower");
        coinscollectedfinal.text = ("You collected: " + Collectable.coinscollected + "/5 Coins ");

        GameObject varGameObject = GameObject.FindWithTag("Player");
        varGameObject.GetComponent<PlayerMovement>().enabled = false;
        Music.enabled = false;  
        barsandtings.enabled = false;
        timer.SendMessage("finish");
        yield return new WaitForSeconds(1.5f);
        AudioSource audio = GetComponent<AudioSource>();

        crown.SetBool("Gameendanim", true);
        audio.Play();
        
        yield return new WaitForSeconds(2f);
        audio.clip = explosion;
        audio.Play();   
        crownobj.enabled = false;
        explode.SetActive(true);

       yield return new WaitForSeconds(2f);
        notreal.SetActive(true);

        yield return new WaitForSeconds(5f);
        fadeout.SetActive(true);
        notreal.SetActive(false);
        fade.SetBool("End", true);
        
        yield return new WaitForSeconds(2f);
        Congrats.SetActive(true);


        yield return new WaitForSeconds(9.3f);
        Timetaken.SetActive(true);
       

        yield return new WaitForSeconds(5.5f);
        JumpsDone.SetActive(true);

        yield return new WaitForSeconds(4.5f);
        CoinsCollected.SetActive(true);

        yield return new WaitForSeconds(5f);
        ExitScene.SetActive(true);
        endbutton.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      StartCoroutine(Endsceneswag());   
    }

}
