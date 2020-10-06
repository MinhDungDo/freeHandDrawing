using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiActive : MonoBehaviour
{
    public List<GameObject> listOfUI;

    private bool uiStatus;

    public void MethodsToCallOnPress()
    {
        if(listOfUI[0].activeSelf)
        {
            uiStatus = true;
        }
        else
        {
            uiStatus = false;
        }
        foreach (GameObject ui in listOfUI)
        {
            ui.SetActive(!uiStatus);
        }
    }
}
