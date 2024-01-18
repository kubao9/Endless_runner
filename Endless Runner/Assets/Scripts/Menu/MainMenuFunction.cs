using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    void Start()
    {
        ObstacleCollision.isCollision = false;
        LevelDistance.addingDistance = true;
        PlayerMove.canMove = false;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

  
}
