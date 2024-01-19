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
    public Text textYourRunScore;
    public Text textGameOver;
    public Text textCoinsCollected;
    public Text textTotalScore;
    public static string yourRunScore = "Your run distance:";
    public static string gameOver= "Game Over";
    public static string coinsCollected = "Coins Collected:";
    public static string totalScore = "Total Score:";



    void Start()
    {
        textYourRunScore.text = yourRunScore;
        textGameOver.text = gameOver;
        textCoinsCollected.text = coinsCollected;
        textTotalScore.text = totalScore;

    }
    void Update()
    {
        if(ObstacleCollision.isCollision==true)
        {
            StartCoroutine(LevelEnd());
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
