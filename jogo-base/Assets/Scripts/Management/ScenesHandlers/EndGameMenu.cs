using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
<<<<<<< HEAD
using TMPro;

public enum Result{ VICTORY, DEFEAT, COMPLETED};
=======

public enum Result{ VICTORY, DEFEAT};
>>>>>>> 89a5c871158c25ebd93e654053b747dd1a922756

public class EndGameMenu : MonoBehaviour {

    public GameObject endMenu;
<<<<<<< HEAD
    public TMP_Text resultText;
    public TMP_Text timeText;

	public void show(Result result, float time)
    {
        PauseMenu.gameIsPaused = true;
=======
    public Text resultText;
    public Text timeText;

	public void show(Result result, float time)
    {
>>>>>>> 89a5c871158c25ebd93e654053b747dd1a922756
        endMenu.SetActive(true);
        Time.timeScale = 0f;
        if(result== Result.VICTORY)
        {
<<<<<<< HEAD
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
=======
            resultText.text = "VITÓRIA";
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "DERROTA";
            resultText.color = Color.red;
        }
>>>>>>> 89a5c871158c25ebd93e654053b747dd1a922756
    }

    public void loadMenu()
    {
        Time.timeScale = 1f;
<<<<<<< HEAD
        GameManager.instance.userAgainst = null; 
=======
        GameManager.instance.userAgainst = null;
>>>>>>> 89a5c871158c25ebd93e654053b747dd1a922756
        SceneManager.LoadScene("scenes/GameTypeChoose");
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void repeat()
    {
<<<<<<< HEAD
        Time.timeScale = 1f;
        PauseMenu.gameIsPaused = false;
        if (GameManager.instance.levelChoosen == 1)
        {
            SceneManager.LoadScene("Scenes/Level1");
        }
            
=======
        if(GameManager.instance.levelChoosen == 1)
            SceneManager.LoadScene("Scenes/Level1");
>>>>>>> 89a5c871158c25ebd93e654053b747dd1a922756
    }




}
