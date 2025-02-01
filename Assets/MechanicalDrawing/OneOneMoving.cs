using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneOneMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // very similar code as the OneOneStandStill Script. Difference here being this one sets scale to 100% on click and disappears when moving is over.
    Boolean isMovingLeft = false;
    Boolean isMovingRight = false;

    Vector3 offScreenScale = new Vector3(0, 0, 0); // hidden sprite
    Vector3 onScreenScaleLeft = new Vector3(1.6876f, 1.6876f, 1.6876f); // normal sprite
    Vector3 onScreenScaleRight = new Vector3(-1.6876f, 1.6876f, 1.6876f); // flipped sprite

    public AnimationCurve curve;

    [Range(0, 1)]
    public float t = 0;

    public Vector2 start = new Vector2(7.72f, -2.8f); // start and end points for oneone to move back and forth
    public Vector2 end = new Vector2(-7.62f, -2.8f);
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // getting mouse position
        Vector2 pos = transform.position;

        if (pos.x == start.x || pos.x == end.x) // if he is at either end, moving is false
        {
            isMovingLeft = false;
            isMovingRight = false;
            transform.localScale = offScreenScale; // hide sprite while not moving
        }


        if (isMovingLeft == false && isMovingRight == false) // if moving is false, reset t
        {
            t = 0;
            if (Input.GetMouseButtonDown(0)) // if moving is false and mouse is clicked on oneone, moving is now true
            {
                if (mousePos.x >= pos.x - 2.5 && mousePos.x <= pos.x + 2.5 && mousePos.y >= pos.y - 2.5 && mousePos.y <= pos.y + 2.5)
                {
                    if (pos.x == start.x)
                    {
                        isMovingLeft = true;
                        transform.localScale = onScreenScaleLeft; // show sprite
                    }
                    else if (pos.x == end.x)
                    {
                        isMovingRight = true;
                        transform.localScale = onScreenScaleRight; // show sprite flipped
                    }


                }
            }
        }
        if (isMovingLeft == true) // move oneone from start to end, or end to start, based on if he is moving left or right
        {
            t += Time.deltaTime;
            transform.position = Vector2.Lerp(start, end, t);
        }
        else if (isMovingRight == true)
        {
            t += Time.deltaTime;
            transform.position = Vector2.Lerp(end, start, t);
        }
    }
}
