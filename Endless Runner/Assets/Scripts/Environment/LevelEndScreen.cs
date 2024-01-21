using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelEndScreen : MonoBehaviour
{
    public GameObject fadeEnd;
    public GameObject endScoreDisplay;
    public GameObject distanceDisplay;
    public GameObject coinDisplay;
    public GameObject YourRunScore;
    public GameObject TotalScore;
    public GameObject CoinsCollected;
    public GameObject GameOver;
    public GameObject bestScoreVal;
    public GameObject textBestScore;

    public static string yourRunScore = "Your run distance:";
    public static string gameOver= "Game Over";
    public static string coinsCollected = "Coins Collected:";
    public static string totalScore = "Total Score:";
    public static string bestScoreTXT = "Highscore:";
    public static bool oneTime = false;
    private int highscore;
    void Start()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            highscore = PlayerPrefs.GetInt("highScore");

        }
        GameOver.GetComponent<TMP_Text>().text = gameOver;
        CoinsCollected.GetComponent<TMP_Text>().text = coinsCollected;
        TotalScore.GetComponent<TMP_Text>().text = totalScore;
        YourRunScore.GetComponent<TMP_Text>().text = yourRunScore;
        textBestScore.GetComponent<TMP_Text>().text = bestScoreTXT;
        bestScoreVal.GetComponent<TMP_Text>().text = "" + highscore;
    }
    void Update()
    {
        if(ObstacleCollision.isCollision==true)
        {
            if(oneTime==false)
            {
                HighScoreSaving();
                oneTime = true;
            }   
            StartCoroutine(LevelEnd());
        }
    }

    public void HighScoreSaving()
    {
        if (PlayerPrefs.HasKey("highScore"))
        {
            if (LevelDistance.total>PlayerPrefs.GetInt("highScore"))
            {
                highscore = LevelDistance.total;
                PlayerPrefs.SetInt("highScore", highscore);
                PlayerPrefs.Save();
                bestScoreVal.GetComponent<TMP_Text>().text = "" + highscore;
            }
        }

        else
        {
            if (LevelDistance.total>highscore)
            {
                highscore = LevelDistance.total;
                PlayerPrefs.SetInt("highScore", highscore);
                PlayerPrefs.Save();
                bestScoreVal.GetComponent<TMP_Text>().text = "" + highscore;;
            }
        }
    }

    IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(1.5f);
        fadeEnd.SetActive(true);
        distanceDisplay.SetActive(false);
        coinDisplay.SetActive(false);
        yield return new WaitForSeconds(1);
        endScoreDisplay.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
