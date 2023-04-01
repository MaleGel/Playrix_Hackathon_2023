using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diary : InHandObject
{
    public GameObject letterObj;
    public GameObject task1Obj;
    public GameObject task2Obj;
    public GameObject task3Obj;
    public GameObject task4Obj;
    public GameObject task5Obj;
    public GameObject task6Obj;

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
        opened = true;
        letterObj.SetActive(true);
        task1Obj.SetActive(true);
        task2Obj.SetActive(true);
        task3Obj.SetActive(true);
        task4Obj.SetActive(true);
        task5Obj.SetActive(true);
        task6Obj.SetActive(true);
        task1Obj.GetComponent<Text>().text = fpsc.text1;
        task2Obj.GetComponent<Text>().text = fpsc.text2;
        task3Obj.GetComponent<Text>().text = fpsc.text3;
        task4Obj.GetComponent<Text>().text = fpsc.text4;
        task5Obj.GetComponent<Text>().text = fpsc.text5;
        task6Obj.GetComponent<Text>().text = fpsc.text6;
    }

    public void CloseLetter()
    {
        fpsc.EnableRagdollSoft();
        opened = false;
        letterObj.SetActive(false);
        task1Obj.SetActive(false);
        task2Obj.SetActive(false);
        task3Obj.SetActive(false);
        task4Obj.SetActive(false);
        task5Obj.SetActive(false);
        task6Obj.SetActive(false);
        task1Obj.GetComponent<Text>().text = "";
        task2Obj.GetComponent<Text>().text = "";
        task3Obj.GetComponent<Text>().text = "";
        task4Obj.GetComponent<Text>().text = "";
        task5Obj.GetComponent<Text>().text = "";
        task6Obj.GetComponent<Text>().text = "";
    }

    public override void ResetObject()
    {
        
    }
}
