﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Controller : MonoBehaviour {


    public static Controller instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;
    private int score = 0;
    public Text ScoreText;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void PlaneScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        ScoreText.text = "Score: " + score.ToString();
    }

    public void PlaneCrashed()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
