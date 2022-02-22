using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugText : MonoBehaviour
{
    public Text jp;
    public Text sp;


    private void Update()
    {
        jp.text = PlayerMovement.JumpSpeed.ToString("F0");
        sp.text = PlayerMovement.sideSpeed.ToString("F0");
    }
}
