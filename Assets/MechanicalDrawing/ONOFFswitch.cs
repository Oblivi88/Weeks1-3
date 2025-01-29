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
    public Boolean on = false;
    // Update is called once per frame
    void Update()
    {
        
        Vector2 pos = transform.position;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (mousePos.x >= pos.x -1 && mousePos.x <= pos.x + 1 && mousePos.y >= pos.y - 0.5 && mousePos.y <= pos.y + 0.5)
            {
                transform.Rotate(0, 0, 90);
                on = !on;
            }
        }
    }
}
