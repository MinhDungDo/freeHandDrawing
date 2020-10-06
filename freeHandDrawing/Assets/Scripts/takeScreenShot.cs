using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeScreenShot : MonoBehaviour
{
    public int width;
    public int height;
    public void MethodsToCallOnPress()
    {
        ScreenShotHandler.TakeScreenshot_Static(width, height);
    }
}
