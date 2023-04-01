using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : InHandObject
{
    public GameObject flashlightLight;
    public Flashlight otherHand;

    public bool enabledFlashlight;
    public float timerOff;


    public override void UseItem()
    {
        if (enabledFlashlight)
        {
            enabledFlashlight = false;
            flashlightLight.SetActive(false);
        }
        else if (!enabledFlashlight && timerOff > 0)
        {
            enabledFlashlight = true;
            flashlightLight.SetActive(true);
        }
    }

    private void Update()
    {
        if (enabledFlashlight && timerOff > 0)
        {
            timerOff -= Time.deltaTime;
        }
        else if (enabledFlashlight && timerOff <= 0)
        {
            enabledFlashlight = false;
            flashlightLight.SetActive(false);
        }
    }

    public void ReffilFlashlight()
    {
        timerOff = 10;
    }

    public override void ResetObject()
    {
        timerOff = 10;
        enabledFlashlight = false;
    }

    public override void DisableObject()
    {
        enabledFlashlight = false;
        flashlightLight.SetActive(false);
    }

    public override void ChangeHand()
    {
        timerOff = otherHand.timerOff;
    }
}
