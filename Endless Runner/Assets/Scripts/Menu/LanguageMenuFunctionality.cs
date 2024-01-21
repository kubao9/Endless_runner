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
        LanguageChanger("Play", "How to play", "Language", "Quit",
                        "Your run distance:", "Game Over", "Coins collected:", "Total Score:",
                        "Good luck!",
                        "Your goal is to avoid obstacles and achieve the highest score possible.",
                        "You gain 1 point for running one meter and 1 point for collecting one coin.",
                        "Use the A & D buttons to move left and right, and press Space to JUMP!",
                        "Go back to menu", "Highscore:");
        SceneManager.LoadScene(0);
    }

    public void Polski()
    {
        LanguageChanger("Graj", "Jak grać", "Język", "Wyjdź z gry",
                        "Pokonany dystans:", "Koniec Gry", "Zebrane monety:", "Twój wynik:",
                        "Powodzenia!",
                        "Twoim celem jest unikanie przeszkód i osiągnięcie jak najwyższego wyniku.",
                        "Zdobędziesz 1 punkt za każdy metr oraz 1 punkt za każdą zebraną monetę.",
                        "Użyj przycisków A oraz D do poruszania się lewo - prawo lub SPACJI aby podskoczyć.",
                        "Wróć do Menu", "Najlepszy wynik:");
        SceneManager.LoadScene(0);
    }

    public void LanguageChanger(string play, string howtoplay, string language, string quit,
                                string yourrunscore, string gameover, string coinscollected,
                                string totalscore, string goodluck, string htp1, string htp2,
                                string htp3, string gotomenu, string bestscore)
    {
        MainMenuFunction.textPlayButton = play;
        MainMenuFunction.textHowToPlay = howtoplay;
        MainMenuFunction.textLanguage = language;
        MainMenuFunction.textQuit = quit;

        LevelEndScreen.yourRunScore = yourrunscore;
        LevelEndScreen.gameOver = gameover;
        LevelEndScreen.coinsCollected = coinscollected;
        LevelEndScreen.totalScore = totalscore;
        LevelEndScreen.bestScoreTXT = bestscore;

        HowToPlayScript.textGoToMenu = gotomenu;
        HowToPlayScript.textHowToPlay = howtoplay;
        HowToPlayScript.textHTP1 = htp1;
        HowToPlayScript.textHTP2 = htp2;
        HowToPlayScript.textHTP3 = htp3;
        HowToPlayScript.textGoodLuck = goodluck;
    }
}
