using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainAdvancer : MonoBehaviour
{
    public GameObject player;
    public float advancement;

    private Score score;
    private int lastScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = player.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lastScore < score.score)
        {
            transform.localScale = new Vector3(transform.localScale.x + advancement, transform.localScale.y, transform.localScale.z);
            lastScore = score.score;
        } 
    }
}
