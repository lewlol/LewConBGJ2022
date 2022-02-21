using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FakeGround : MonoBehaviour
{
    private BoxCollider2D bc;
    private SpriteRenderer sr;
    private BoxCollider2D tc;

    public GameObject shakeParticles;
    public GameObject breakParticles;
    public GameObject block;



    private void Start()
    {
        bc = block.GetComponent<BoxCollider2D>();
        sr = block.GetComponent<SpriteRenderer>();
        tc = gameObject.GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(BreakFloor());
        }
    }

    IEnumerator BreakFloor()
    {
        shakeParticles.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        breakParticles.SetActive(true);
        tc.enabled = false;
        bc.enabled = false;
        sr.enabled = false;
        yield return new WaitForSeconds(5);
        bc.enabled = true;
        sr.enabled = true;
        tc.enabled = true;
        breakParticles.SetActive(false);
        shakeParticles.SetActive(false);
    }
}
