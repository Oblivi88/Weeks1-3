using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Rain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // LOCATION SCREEN SCRIPTS WILL BE VERY SIMILAR, VARYING ONLY IN POSITIONS AND ON/OFF STATE
    // ALSO WILL SHARE SIMILARITIES TO THE BUTTON SCRIPTS

    // vectors for the RESET and main button positions
    Vector3 resetButtonPos = new Vector3(8.68999958f, 2.78999996f, 0f);
    Vector3 buttonPos = new Vector3(-8.63000011f, -0.560000002f, 0f);
    // vector of default scale (on) and off scale (0)
    Vector3 Scale = new Vector3(4.31667566f, 4.31667566f, 4.31667566f);
    Vector3 OffScale = new Vector3(0, 0, 0);
    // sets it off by default
    Boolean off = true;
    void Update()
    {
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

        // if mouse is clicked, and if the mouse position is within the size of the button, turn on rain (scale up)
        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x >= buttonPos.x - 0.5 && mousePos.x <= buttonPos.x + 0.5 && mousePos.y >= buttonPos.y - 0.5 && mousePos.y <= buttonPos.y + 0.5)
            {
                off = false;
            }
            if (mousePos.x >= resetButtonPos.x - 0.7 && mousePos.x <= resetButtonPos.x + 0.7 && mousePos.y >= resetButtonPos.y - 0.7 && mousePos.y <= resetButtonPos.y + 0.7)
            { // if mouse is clicked and mouse position is within the size of the RESET button, turn off rain (scale 0)
                off = true;
            }
        }
    }
}
