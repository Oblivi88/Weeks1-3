using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // ALL BUTTON SCRIPTS WILL BE VERY SIMILAR, VARYING ONLY IN POSITION (RESET BUTTON WILL VARY A LITTLE BIT MORE)

    // vector of default scale (on) and off scale (0)
    Vector3 Scale = new Vector3(1.10753012f, 1.10753012f, 1.10753012f);
    Vector3 OffScale = new Vector3(0, 0, 0);
    // sets it off by default
    Boolean off = true;

    void Update()
    {
        // vector for the RESET button (center)
        Vector3 resetButtonPos = new Vector3(8.68999958f, 2.78999996f, 0f);
        // vector for the position (center)
        Vector2 pos = transform.position;
        // vector for the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // if off do not show
        if (off)
        {
            transform.localScale = OffScale;
        }
        else if (off == false) // if on show
        {
            transform.localScale = Scale;
        }

        // if mouse is clicked, and if the mouse position is within the size of the button, light up (increase scale)
        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x >= pos.x - 1 && mousePos.x <= pos.x + 1 && mousePos.y >= pos.y - 1 && mousePos.y <= pos.y + 1)
            {
                off = false;
            }
            if (mousePos.x >= resetButtonPos.x - 1.3 && mousePos.x <= resetButtonPos.x + 1.3 && mousePos.y >= resetButtonPos.y - 1.3 && mousePos.y <= resetButtonPos.y + 1.3)
            { // if mouse is clicked and mouse position is within the size of the RESET button, turn off
                off = true;
            }
        }
    }
}
