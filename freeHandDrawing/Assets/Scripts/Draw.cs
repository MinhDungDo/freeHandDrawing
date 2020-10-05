using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public GameObject brush;
    GameObject theTrail;
    Plane planeObj;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        //Create a plane from the position of GameObject
        planeObj = new Plane(Camera.main.transform.forward * -1, this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            theTrail = (GameObject)Instantiate(brush, this.transform.position, Quaternion.identity);

            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;
            if (planeObj.Raycast(mouseRay, out distance))
            {
                startPos = mouseRay.GetPoint(distance);
            }
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetMouseButtonDown(0))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float distance;
            if (planeObj.Raycast(mouseRay, out distance))
            {
                theTrail.transform.position = mouseRay.GetPoint(distance);
            }
        }
    }
}
