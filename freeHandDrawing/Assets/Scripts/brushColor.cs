using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brushColor : MonoBehaviour
{
    private Material mat;

    public colorPicker picker;

    private float timer = 0f;
    private float colorTimer = 0.25f;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= colorTimer)
        {
            timer = 0f;
            mat.color = picker.GetColor();
        }
    }
}
