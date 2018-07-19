using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum Result{ VICTORY, DEFEAT};

public class EndGameMenu : MonoBehaviour {

    public GameObject endMenu;
    public Text resultText;
    public Text timeText;

	public void show(Result result, float time)
    {
        endMenu.SetActive(true);
        Time.timeScale = 0f;
        if(result== Result.VICTORY)
        {
            resultText.text = "VITÓRIA";
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "DERROTA";
            resultText.color = Color.red;
        }
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
        if(GameManager.instance.levelChoosen == 1)
            SceneManager.LoadScene("Scenes/Level1");
    }




}
