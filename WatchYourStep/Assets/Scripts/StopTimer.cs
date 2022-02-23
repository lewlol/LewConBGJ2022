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
    public GameObject ExitScene;
    public Text TotalJumps;
    public Text Totaltime;
    public Animator crown;
    public SpriteRenderer crownobj;
    public GameObject explode;
    public AudioClip explosion;
    public AudioSource Music;
    public GameObject notreal;
    public GameObject typing;
    IEnumerator Endsceneswag()
    {
        TotalJumps.text = ("You jumped a total of: " + PlayerMovement.jumpCount + " times during your run");
        Totaltime.text = ("You took " + Stopwatch.minutesfinal + ":" + Stopwatch.secondsfinal + " to reach the top of the tower");

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


        yield return new WaitForSeconds(4f);
        notreal.SetActive(false);
        fadeout.SetActive(true);
        fade.SetBool("End", true);
        yield return new WaitForSeconds(2f);

        typing.SetActive(true);
        Congrats.SetActive(true);
        yield return new WaitForSeconds(9.3f);

        yield return new WaitForSeconds(0.1f);
        typing.SetActive(false);
        yield return new WaitForSeconds(0.1f);

        Timetaken.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        JumpsDone.SetActive(true);
        yield return new WaitForSeconds(7f);
        ExitScene.SetActive(true);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      StartCoroutine(Endsceneswag());   
    }

}
