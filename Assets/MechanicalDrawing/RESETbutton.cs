using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RESETbutton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // ALL BUTTON SCRIPTS WILL BE VERY SIMILAR, VARYING ONLY IN POSITION (RESET BUTTON WILL VARY A LITTLE BIT MORE)
    // THE MAIN SCREEN SPRITES WILL ALSO SHARE MANY SIMILARITIES 

    // vector of default scale (on) and off scale (0)
    Vector3 Scale = new Vector3(1.33490598f, 1.33490598f, 1.33490598f);
    Vector3 OffScale = new Vector3(0, 0, 0);
    // sets it off by default
    Boolean off = true;

    void Update()
    {
        // vector for the position (center)
        Vector2 pos = transform.position;
        // vector for the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // if off do not show
        if (off)
        {
            transform.localScale = OffScale;
        }
        else if (off == false) // if on light up
        {
            transform.localScale = Scale;
        }

        // while the mouse button is held, and it is within the size of the reset button, light up
        if (Input.GetMouseButton(0))
        {
            if (mousePos.x >= pos.x - 0.7 && mousePos.x <= pos.x + 0.7 && mousePos.y >= pos.y - 0.7 && mousePos.y <= pos.y + 0.7)
            {
                off = false;
            } 
        }
        else
        {
            off = true;
        }

    }
}
