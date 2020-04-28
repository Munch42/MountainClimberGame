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

    public GameObject gameMechanic;

    private GameMechanics gameMechanics;

    private float startY;
    private int lastScore;

    private void Start()
    {
        score = 0;
        startY = transform.position.y;
        startY *= -1;
        lastScore = 0;
        loseText.text = "";

        gameMechanics = gameMechanic.GetComponent<GameMechanics>();
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
            loseText.text = "You lost my triangle friend!\n\nPress Enter To Restart!";
            // Due to destruction, this will be handled in other script so we need to tell it that it is game over.
            gameMechanics.gameOver = true;
            Destroy(this.gameObject);
        }
    }
}
