using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiltScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            this.transform.Rotate(0, 0, 2);   
        }
        if (Input.GetKeyDown("d"))
        {
            this.transform.Rotate(0, 0, -2);
        }
        //this.transform.Rotate(0, 0, Input.acceleration.z); 
    }
}
