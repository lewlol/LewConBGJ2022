using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockShake : MonoBehaviour
{
    [Header("Info")]
    private Vector3 _startPos;
    private float _timer;
    private Vector3 _randomPos;

    [Header("Settings")]
    [Range(0f, 2f)]
    public float _time = 0.2f;
    [Range(0f, 2f)]
    public float _distance = 0.1f;
    [Range(0f, 0.1f)]
    public float _delayBetweenShakes = 0f;


    public float shakeTimer;
    public float maxShakeTimer;


    public AudioSource audio;
    public AudioClip laugh;

    public float rPitch;

    private void Awake()
    {
        _startPos = transform.position;
        maxShakeTimer = 7;
    }

    private void OnValidate()
    {
        if (_delayBetweenShakes > _time)
            _delayBetweenShakes = _time;
    }
    private void Update()
    {
        if(shakeTimer < maxShakeTimer)
        {
            shakeTimer += Time.deltaTime;
        } else if(shakeTimer >= maxShakeTimer)
        {
            shakeTimer = 0;
            StartCoroutine(Shake());
        }
    }

    private IEnumerator Shake()
    {
        _timer = 0f;

        while (_timer < _time)
        {
            _timer += Time.deltaTime;

            _randomPos = _startPos + (Random.insideUnitSphere * _distance);

            transform.position = _randomPos;

            if (_delayBetweenShakes > 0f)
            {
                yield return new WaitForSeconds(_delayBetweenShakes);
            }
            else
            {
                yield return null;
            }
        }

        transform.position = _startPos;
        StopCoroutine(Shake());
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            RandomNumber();
            audio.clip = laugh;
            audio.Play();
        }
    }

    void RandomNumber()
    {
        rPitch = Random.Range(1, 3);
        audio.pitch = rPitch;
    }
}
