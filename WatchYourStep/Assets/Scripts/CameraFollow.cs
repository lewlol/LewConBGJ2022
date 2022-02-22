using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        offset = new Vector3(0, 3, 0);
    }
    void Update()
    {
        if(gameObject.transform.position.y < 165)
        {
            Vector3 position = transform.position;
            position.y = (player.position + offset).y;
            transform.position = position;
        }
    }
}
