using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMechanics : MonoBehaviour
{
    // For audio file type info: https://answers.unity.com/questions/869456/wav-or-mp3-for-audioclips.html

    public bool gameOver = false;

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
