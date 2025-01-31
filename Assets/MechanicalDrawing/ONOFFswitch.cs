using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONOFFswitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // a small code snippet to rotate the switch when clicked
    void Update()
    {
        // vector for the position (center)
        Vector2 pos = transform.position;
        // vector for the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // if mouse is clicked, and if the mouse position is within the size of the shape, rotate 90 degrees
        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x >= pos.x -1 && mousePos.x <= pos.x + 1 && mousePos.y >= pos.y - 0.5 && mousePos.y <= pos.y + 0.5)
            {
                transform.Rotate(0, 0, 90); 
            }
        }
    }
}
