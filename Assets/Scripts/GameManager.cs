using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public static GameManager instance;
    public float game_speed;

    public bool isPaused = true;
    public bool isGameOver = false;
    int score = 0;

    [SerializeField]
    GameObject menu, gameoverUI, pauseUI, pauseButton;

    [SerializeField]
    Text scoreField;

    [SerializeField]
    Bird_Controller bird;

    [SerializeField]
    Obstacle_Pool obstacles;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }

    void Start () {
        Time.timeScale = 0f;
	}
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void StartGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        isGameOver = false;
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
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        gameoverUI.SetActive(true);
        pauseButton.SetActive(false);
        isGameOver = true;
    }

    public void Restart()
    {
        bird.ResetBird();
        pauseButton.SetActive(true);
        isGameOver = false;
        score = 0;
        scoreField.text = score.ToString();
        obstacles.ResetObstacles();

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
