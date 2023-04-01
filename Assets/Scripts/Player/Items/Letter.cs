using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : InHandObject
{
    public GameObject letterObj;
    public GameObject letterTextObj;
    public LetterShower letterId;
    public FirstPersonController fpsc;

    public bool opened;

    public override void UseItem()
    {
        if (!opened)
        {
            ShowLetter();
        }
        else
        {
            CloseLetter();
        }
    }

    public void ShowLetter()
    {
        fpsc.DisableRagdollSoft();
        letterObj.SetActive(true);
        letterTextObj.SetActive(true);
        opened= true;
        letterTextObj.GetComponent<Text>().text = letterId.letterText;
    }

    public void CloseLetter()
    {
        fpsc.EnableRagdollSoft();
        letterObj.SetActive(false);
        letterTextObj.SetActive(false);
        opened = false;
        letterTextObj.GetComponent<Text>().text = "";
    }

    public override void ResetObject()
    {
        
    }
}
