using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorPicker : MonoBehaviour
{
    public Image brushColor;

    private float r = 1f;
    private float g = 1f;
    private float b = 1f;

    private Color selectedColor;

    // Start is called before the first frame update
    void Start()
    {
        SetColor();
    }

    public void SetR(float _r)
    {
        r = _r;
        SetColor();
    }

    public void SetG(float _g)
    {
        g = _g;
        SetColor();
    }

    public void SetB(float _b)
    {
        b = _b;
        SetColor();
    }

    private void SetColor()
    {
        selectedColor = new Color(r, g, b);
        brushColor.color = selectedColor;
    }

    public Color GetColor()
    {
        return selectedColor;
    }
}
