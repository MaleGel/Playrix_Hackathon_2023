using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Helper : MonoBehaviour
{
    public GameObject helpText;

    public void ShowHelpText()
    {

    }
    public void ShowHelpPickUpText(string objName)
    {
        helpText.SetActive(true);
        helpText.GetComponent<Text>().text = "Чтобы поднять '" + objName + "' нажмите ЛКМ/ПКМ";
    }

    public void DisableHelper()
    {
        helpText?.SetActive(false);
    }
}
