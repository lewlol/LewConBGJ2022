using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockShake : MonoBehaviour
{
    Vector2 startingPos;

    private float speed = 1.0f;

    void Awake()
    {
        startingPos.x = transform.position.x;
        startingPos.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

        //gameObject.transform.position.x = (startingPos.x + Mathf.Sin(Time.time * speed) * amount );

        //gameObject.transform.position.y = (startingPos.y + (Mathf.Sin(Time.time * speed) * amount) );

    }
}
