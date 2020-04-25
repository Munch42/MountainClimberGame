using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + yOffset, -20); 
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y + yOffset, -20);
    }
}
