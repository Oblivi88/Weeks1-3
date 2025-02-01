using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // a boolean storing whether or not the image is on screen (starts OFF)
    Boolean on = false;
    void Update()
    {

        Vector3 Switchpos = new Vector3(-8.56000042f, 2.22000003f, 0f); // vector for the position of the switch
        Vector3 offStateScale = new Vector3(0, 0, 0); // vector for the scale its off state (gone)
        Vector3 onStateScale = new Vector3(3.52870011f, 3.52870011f, 3.52870011f); // vector for the scale in its on state
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // getting mouse position

        // if it is on, show, if not, scale 0
        if (on)
        {
            transform.localScale = onStateScale;
        }
        else
        {
            transform.localScale = offStateScale;
        }

        // if the mouse is clicked and if the mouse is within the size of the shape of the switch,
        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x >= Switchpos.x - 1 && mousePos.x <= Switchpos.x + 1 && mousePos.y >= Switchpos.y - 0.5 && mousePos.y <= Switchpos.y + 0.5)
            {
                // if it is on, turn it off, and vice versa
                if (on)
                {
                    on = false;
                }
                else
                {
                    on = true;
                }

            }
        }
    }
}
