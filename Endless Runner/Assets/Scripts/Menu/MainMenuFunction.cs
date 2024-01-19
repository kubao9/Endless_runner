using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MainMenuFunction : MonoBehaviour
{
    public static string textPlayButton = "Play";
    public static string textHowToPlay = "How to play";
    public static string textLanguage = "Language";
    public static string textQuit = "Quit";

    void Start()
    {
        GameObject.Find("PlayButton").GetComponentInChildren<TMP_Text>().text = textPlayButton;
        GameObject.Find("HowToPlayButton").GetComponentInChildren<TMP_Text>().text = textHowToPlay;
        GameObject.Find("LanguageButton").GetComponentInChildren<TMP_Text>().text = textLanguage;
        GameObject.Find("QuitButton").GetComponentInChildren<TMP_Text>().text = textQuit;

        ObstacleCollision.isCollision = false;
        LevelDistance.addingDistance = true;
        PlayerMove.canMove = false;
        LevelDistance.coinAmount = 0;
        LevelDistance.total = 0;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Language()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

  
}
