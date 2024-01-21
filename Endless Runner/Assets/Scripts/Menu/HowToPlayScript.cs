using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HowToPlayScript : MonoBehaviour
{
    public static string textHowToPlay = "How to play";
    public static string textGoodLuck = "Good luck!";
    public static string textHTP1 = "Your goal is to avoid obstacles and achieve the highest score possible.";
    public static string textHTP2 = "You gain 1 point for running one meter and 1 point for collecting one coin.";
    public static string textHTP3 = "Use the A & D buttons to move left and right, and press Space to JUMP!";
    public static string textGoToMenu = "Go back to menu";

    public void Start()
    {
        GameObject.Find("GoBackToMenuButton").GetComponentInChildren<TMP_Text>().text = textGoToMenu;
        GameObject.Find("HowToPlayTXT").GetComponent<TMP_Text>().text = textHowToPlay;
        GameObject.Find("HTP1TXT").GetComponent<TMP_Text>().text = textHTP1;
        GameObject.Find("HTP2TXT").GetComponent<TMP_Text>().text = textHTP2;
        GameObject.Find("HTP3TXT").GetComponent<TMP_Text>().text = textHTP3;
        GameObject.Find("GoodLuckTXT").GetComponent<TMP_Text>().text = textGoodLuck;


    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
