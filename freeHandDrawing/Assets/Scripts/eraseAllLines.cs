using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eraseAllLines : MonoBehaviour
{
    
    public void MethodsToCallOnPress()
    {
        var listOfLines = GameObject.FindGameObjectsWithTag("Line");
        foreach(GameObject Line in listOfLines)
        {
            if(Line.name.Contains("Clone"))
            {
                Destroy(Line);
            }
        }

    }
}
