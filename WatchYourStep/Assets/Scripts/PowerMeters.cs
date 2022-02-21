using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerMeters : MonoBehaviour
{
    public Slider jumpSlider;
    public Slider sideSlider;

    private void Update()
    {
        jumpSlider.value = PlayerMovement.JumpSpeed;
        jumpSlider.maxValue = PlayerMovement.maxJumpSpeed;

        sideSlider.value = PlayerMovement.sideSpeed;
        sideSlider.maxValue = PlayerMovement.maxSideSpeed;
        if(PlayerMovement.sideSpeed < 0)
        {
            sideSlider.value = -PlayerMovement.sideSpeed;
        }
    }

}
