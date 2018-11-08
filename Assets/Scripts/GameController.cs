﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static GameController instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = 1.5f;

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
	
}