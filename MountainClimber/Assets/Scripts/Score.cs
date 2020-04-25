using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;

    public Text scoreText;
    public Text loseText;

    public bool gameOver = false;

    private float startY;
    private int lastScore;

    private void Start()
    {
        score = 0;
        startY = transform.position.y;
        startY *= -1;
        lastScore = 0;
        loseText.text = "";
    }

    private void Update()
    {
        score = Mathf.RoundToInt(transform.position.y + startY);
        if(lastScore > score)
        {
            score = lastScore;
        }
        scoreText.text = score.ToString();
        lastScore = score;

        if (gameOver)
        {
            loseText.text = "You lost my triangle friend!";
            Destroy(this.gameObject);
        }
    }
}
