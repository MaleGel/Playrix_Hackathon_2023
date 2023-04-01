using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batteries : InHandObject
{
    public Flashlight rightFlashlight;
    public Flashlight leftFlashlight;
    public FirstPersonController fpsc;
    public override void UseItem()
    {
        if (fpc.leftHandObj != null && fpc.leftinhandobject.itemName == "Flashlight")
        {
            leftFlashlight.ReffilFlashlight();
            gameObject.SetActive(false);
            fpsc.animator.SetBool("SomethingInRight", false);
            fpsc.rightinhandobject.DisableObject();
            fpsc.rightHandObj = null;
        }
        else if (fpc.rightHandObj != null && fpc.rightinhandobject.itemName == "Flashlight")
        {
            rightFlashlight.ReffilFlashlight();
            gameObject.SetActive(false);
            fpsc.animator.SetBool("SomethingInLeft", false);
            fpsc.leftinhandobject.DisableObject();
            fpsc.leftHandObj = null;
        }
    }

    public override void ResetObject()
    {
        
    }
}
