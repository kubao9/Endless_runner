using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ObstacleCollision.isCollision = false;
        LevelDistance.addingDistance = true;
        PlayerMove.canMove = false;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

  
}
