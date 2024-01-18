using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LanguageMenuFunctionality : MonoBehaviour
{
    public void English()
    {
        GameObject.Find("PlayButton").GetComponentInChildren<TMP_Text>().text = "Play";
        SceneManager.LoadScene(0);
    }
}
