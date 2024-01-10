using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelEndScreen : MonoBehaviour
{
    public GameObject fadeEnd;
    public GameObject endScoreDisplay;
    public GameObject distanceDisplay;

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
