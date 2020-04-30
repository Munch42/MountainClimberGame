using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
        if(viewPos.x > -0.1)
        {
            Debug.Log(viewPos.x);
            transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position = new Vector3(viewPos.x + 6f, viewPos.y, 0);
        }    

        
        
    }
}
