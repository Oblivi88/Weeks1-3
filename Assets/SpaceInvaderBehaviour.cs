using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaderBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);




        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            transform.position = mousePos;
        }
    }
}
