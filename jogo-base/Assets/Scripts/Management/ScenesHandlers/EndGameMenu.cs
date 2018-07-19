using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public enum Result { VICTORY, DEFEAT, COMPLETED };

public class EndGameMenu : MonoBehaviour
{

    public GameObject endMenu;
    public TMP_Text resultText;
    public TMP_Text timeText;

    public void show(Result result, float time)
    {
        endMenu.SetActive(true);
        Time.timeScale = 0f;
        if (result == Result.VICTORY)
        {
            resultText.text = "VICTORY!";
            resultText.color = Color.green;
        }
        else if (result == Result.DEFEAT)
        {
            resultText.text = "DEFEAT!";
            resultText.color = Color.red;
        }
        else
        {
            resultText.text = "LEVEL COMPLETED!";
            resultText.color = Color.cyan;
        }
        timeText.text = "TIME : " + System.Math.Round(time, 2) + " seconds";
        timeText.color = Color.white;
    }

    public void loadMenu()
    {
        Time.timeScale = 1f;
        GameManager.instance.userAgainst = null;
        SceneManager.LoadScene("scenes/GameTypeChoose");
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void repeat()
    {
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        if (GameManager.instance.levelChoosen == 1)
        {
            SceneManager.LoadScene("Scenes/Level1");
        }
        else if (GameManager.instance.levelChoosen == 2)
        {
            SceneManager.LoadScene("Scenes/Level2");
        }
    }

}