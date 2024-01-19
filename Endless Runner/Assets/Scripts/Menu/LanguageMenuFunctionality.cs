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
        MainMenuFunction.textPlayButton = "Play";
        MainMenuFunction.textHowToPlay = "How to play";
        MainMenuFunction.textLanguage = "Language";
        MainMenuFunction.textQuit = "Quit";

        LevelEndScreen.yourRunScore = "Your run score:";
        LevelEndScreen.gameOver = "Game Over";

        SceneManager.LoadScene(0);
    }

    public void Polski()
    {
        MainMenuFunction.textPlayButton = "Graj";
        MainMenuFunction.textHowToPlay = "Jak graæ";
        MainMenuFunction.textLanguage = "Jêzyk";
        MainMenuFunction.textQuit = "WyjdŸ z gry";

        LevelEndScreen.yourRunScore = "Twój wynik:";
        LevelEndScreen.gameOver = "Koniec Gry";

        SceneManager.LoadScene(0);
    }
}
