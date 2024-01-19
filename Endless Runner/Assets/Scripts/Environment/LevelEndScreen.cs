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
    public Text textYourRunScore;
    public Text textGameOver;
    public static string yourRunScore = "Your run score:";
    public static string gameOver= "Game Over";

    void Start()
    {
        textYourRunScore.text = yourRunScore;
        textGameOver.text = gameOver;
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
        yield return new WaitForSeconds(1);
        endScoreDisplay.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);

    }
}
