using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderScript : MonoBehaviour
{
    private Score score;

    private void Start()
    {
        Destroy(this.gameObject, 20f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            score = collision.gameObject.GetComponent<Score>();
            score.gameOver = true;
        }

        if(collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
