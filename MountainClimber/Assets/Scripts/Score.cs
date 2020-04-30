using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;

    public Text scoreText;
    public Text loseText;
    public Text highScore;

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

        highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
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

        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = "High Score: " + score.ToString();
            Color32 beatColor = new Color32(237, 183, 22, 255);
            highScore.color = beatColor;
        }

        if (gameOver)
        {
            loseText.text = "You lost my triangle friend!\n\nPress Enter To Restart!\nPress Escape To Return To The Main Menu!";
            // Due to destruction, this will be handled in other script so we need to tell it that it is game over.
            gameMechanics.gameOver = true;
            Destroy(this.gameObject);
        }
    }
}
