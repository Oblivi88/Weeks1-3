using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpaceInvader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if mouse is clicked, sprite moves to mouse position
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 invaderPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = invaderPos;
        }
        
    }
}
