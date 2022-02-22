using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject pl;
    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        offset = new Vector3(0, 3, 0);
    }
    void Update()
    {
        if (pl.transform.position.y < 166)
        {
            Vector3 position = transform.position;
            position.y = (player.position + offset).y;
            transform.position = position;
        }
    }
}
