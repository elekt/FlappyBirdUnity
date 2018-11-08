using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = 1.5f;

    int score = 0;
    public Text scoreText; 

    void Awake() 
    {
        if(instance == null) 
        {
            instance = this;
        }
    }

    void Update() 
    {
        if(gameOver && Input.GetMouseButtonDown(0)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

	public void BirdDied () 
    {
        gameOverText.SetActive(true);
        gameOver = true;
	}

    public void BirdScored() 
    {
        if(gameOver) {
            return;
        }

        score++;
        UpdateScore();
    }

    void Start() 
    {
        score = 0;
        UpdateScore();
    }

    void UpdateScore() 
    {
        scoreText.text = "Score: " + score;
    }
	
}
