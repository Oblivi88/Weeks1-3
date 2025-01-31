using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // a boolean storing whether or not the image is on screen (starts on)
    Boolean isOnScreen = true;
    void Update()
    {
        
        Vector3 Switchpos = new Vector3(-8.56000042f,2.22000003f,0f); // vector for the position of the switch
        Vector3 offStateScale = new Vector3(0, 0, 0); // vector for the scale of this image in its off state (gone)
        Vector3 onStateScale = new Vector3(1.82022333f, 1.57586706f, 1f); // vector for the scale of this image in its on state (how it will look on screen)
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // getting mouse position
        // if the mouse is clicked and if the mouse is within the size of the shape of the switch,
        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x >= Switchpos.x - 1 && mousePos.x <= Switchpos.x + 1 && mousePos.y >= Switchpos.y - 0.5 && mousePos.y <= Switchpos.y + 0.5)
            {
                // if the screen is on, turn it off, and vice versa (changing the scale to 0 and back)
                if (isOnScreen)
                {
                    transform.localScale = offStateScale;
                    isOnScreen = false;
                } else
                {
                    transform.localScale = onStateScale;
                    isOnScreen = true;
                }
                
            }
        }
    }
}
