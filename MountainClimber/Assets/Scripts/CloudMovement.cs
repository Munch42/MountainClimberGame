﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = -1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 lowerBound = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)); 
        Vector3 upperBound = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        if (viewPos.x > -0.1)
        {
            //Debug.Log("X: " + viewPos.x);
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position = new Vector3(viewPos.x + upperBound.x, transform.position.y, 0);
        }

        if (viewPos.y > -0.1)
        {
            //Debug.Log("Y: " + viewPos.y);
            transform.position += new Vector3(0, 0, 0);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, viewPos.y + upperBound.y, 0);
        }


    }
}
