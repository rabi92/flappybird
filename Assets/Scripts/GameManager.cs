using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField]
    float game_speed;

    public bool isPaused = true;
    public bool isGameOver = false;
    int score = 0;

    [SerializeField]
    GameObject menu, gameoverUI, pauseUI, pauseButton;

    [SerializeField]
    Text scoreField;

    [SerializeField]
    Bird_Controller bird;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void StartGame()
    {
        //disable menu
        menu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void UpdateScore()
    {
        score++;
        scoreField.text = score.ToString();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame()
    {
        print("Pause Button Pressed!");
        //pause game
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        //Show Gameover UI
        gameoverUI.SetActive(true);
        pauseButton.SetActive(false);
    }

    public void Restart()
    {
        bird.transform.position = Vector3.zero;
        //reset bird y
        //reset obstacles
        //reset score

        //update booleans

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
