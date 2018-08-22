using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	//A time limit set for the game in this case 20 seconds
    public bool timedLevel = false;
    public float timeRemaining = 20.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //An if else statement making sure that when time is up the game over scene will load
		if (timedLevel)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0)
            {
                LoadNextScene();
            }
        }

    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // retrieves the current scene index        
        SceneManager.LoadScene(currentSceneIndex + 1); // allowing the scene to be loaded
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0); // A prompt making sure the main menu is loaded when the game is executed
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene(1); // A prompt making sure the main level is loaded
    }
}
