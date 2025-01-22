using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class CircleWeek3 : MonoBehaviour
{
    public AnimationCurve jump;
    public float t;
    public float speed = 0.02f;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 circlePos = transform.position;
        circlePos.x += speed;
        circlePos.y = height;

        Vector2 inScreenSpace = Camera.main.WorldToScreenPoint(circlePos);

        if (inScreenSpace.x < 0 || inScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = circlePos;


        if (Input.GetKey("space"))
        {
            Debug.Log("Testinggg");
            t += 0.01f;
            height = jump.Evaluate(t);

        } else
        {
            height = 0;
            t = 0;
        }

    }
    
}
