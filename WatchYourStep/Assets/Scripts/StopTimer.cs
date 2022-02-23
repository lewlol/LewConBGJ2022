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
    IEnumerator Endsceneswag()
    {
        TotalJumps.text = ("You jumped a total of: " + PlayerMovement.jumpCount + " times during your run");
        Totaltime.text = ("You took " + Stopwatch.minutesfinal + ":" + Stopwatch.secondsfinal + " to reach the top of the tower");

        AudioListener.pause = true;
        barsandtings.enabled = false;
        timer.SendMessage("finish");
        yield return new WaitForSeconds(1.5f);

        crown.SetBool("Gameendanim", true);
        yield return new WaitForSeconds(2f);
        crownobj.enabled = false;
        explode.SetActive(true);


        yield return new WaitForSeconds(2);
        fadeout.SetActive(true);
        fade.SetBool("End", true);
        yield return new WaitForSeconds(2f);

        Congrats.SetActive(true);
        yield return new WaitForSeconds(9.3f);
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
