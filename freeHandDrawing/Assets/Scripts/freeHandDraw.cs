﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class freeHandDraw : MonoBehaviour
{
    public GameObject linePrefab;
    private GameObject currentLine;

    private LineRenderer lineRenderer;
    public List<Vector2> fingerPositions;

    private bool validInput = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            drawLine();
        }
        if (Input.GetMouseButton(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(tempFingerPos, fingerPositions[fingerPositions.Count - 1]) > .1f)
            {
                UpdateLine(tempFingerPos);
            }
        }
    }

    void drawLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        fingerPositions.Clear();
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0, fingerPositions[0]);
        lineRenderer.SetPosition(1, fingerPositions[1]);
    }

    void UpdateLine(Vector2 newFingerPos)
    {
        fingerPositions.Add(newFingerPos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
    }
}
