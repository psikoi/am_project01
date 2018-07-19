using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public enum Result{ VICTORY, DEFEAT, COMPLETED};

public class EndGameMenu : MonoBehaviour {

    public GameObject endMenu;
    public TMP_Text resultText;
    public TMP_Text timeText;

	public void show(Result result, float time)
    {
        PauseMenu.gameIsPaused = true;
        endMenu.SetActive(true);
        Time.timeScale = 0f;
        if(result== Result.VICTORY)
        {
            resultText.text = "VITÓRIA!";
            resultText.color = Color.green;
        }
        else if(result == Result.DEFEAT)
        {
            resultText.text = "DERROTA!";
            resultText.color = Color.red;
        }
        else 
        {
            resultText.text = "NIVEL COMPLETADO!";
            resultText.color = Color.cyan;
        }
        timeText.text = "Tempo : "+time+ " segundos";
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
            
    }




}
