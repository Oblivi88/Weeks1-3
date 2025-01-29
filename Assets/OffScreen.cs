using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OffScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        onOff = GetComponent<ONOFFswitch>();
    }

    // Update is called once per frame
    void Update()
    {
        if(OnOff.on)
        {
            Destroy(gameObject);
        }
    }
}
