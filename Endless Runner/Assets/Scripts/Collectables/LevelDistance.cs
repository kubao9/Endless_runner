using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject distanceDisplay;
    public GameObject coinDisplay;
    public GameObject distanceEndDisplay;
    public GameObject coinEndDisplay;
    public GameObject totalScore;
    public int distanceRun;
    static public int coinAmount=0;
    static public int total;

    public static bool addingDistance = true;
    public static float distanceDelay = 0.35f;
    void Update()
    {
        coinDisplay.GetComponent<TMP_Text>().text = "" + coinAmount;
        coinEndDisplay.GetComponent<TMP_Text>().text = "" + coinAmount;
        if (ObstacleCollision.isCollision == false)
        {
            if (addingDistance == false)
            {
                addingDistance = true;
                StartCoroutine(AddingDistance());
            }
        }
        total = coinAmount + distanceRun;
        totalScore.GetComponent<TMP_Text>().text = "" + total;

    }

    IEnumerator AddingDistance()
    {
        distanceRun += 1;
        distanceDisplay.GetComponent<TMP_Text>().text = "" + distanceRun;
        distanceEndDisplay.GetComponent<TMP_Text>().text = "" + distanceRun;
        yield return new WaitForSeconds(distanceDelay);
        addingDistance=false;
    }
}
