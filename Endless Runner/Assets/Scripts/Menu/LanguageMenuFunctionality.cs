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
        LanguageChanger("Play", "How to play", "Language", "Quit", "Your run distance:", "Game Over", "Coins collected:", "Total Score:");
        SceneManager.LoadScene(0);
    }

    public void Polski()
    {
        LanguageChanger("Graj", "Jak graæ", "Jêzyk", "WyjdŸ z gry", "Pokonany dystans:", "Koniec Gry", "Zebrane monety:", "Wynik:");
        SceneManager.LoadScene(0);
    }

    public void LanguageChanger(string play, string howtoplay, string language, string quit, string yourrunscore, string gameover, string coinscollected, string totalscore)
    {
        MainMenuFunction.textPlayButton = play;
        MainMenuFunction.textHowToPlay = howtoplay;
        MainMenuFunction.textLanguage = language;
        MainMenuFunction.textQuit = quit;

        LevelEndScreen.yourRunScore = yourrunscore;
        LevelEndScreen.gameOver = gameover;
        LevelEndScreen.coinsCollected = coinscollected;
        LevelEndScreen.totalScore = totalscore;
    }
}
