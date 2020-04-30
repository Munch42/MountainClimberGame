using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScripts : MonoBehaviour
{
    public Text scoreResetText;

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        StartCoroutine("turnTextOnOff");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator turnTextOnOff()
    {
        scoreResetText.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        scoreResetText.gameObject.SetActive(false);
    }
}
