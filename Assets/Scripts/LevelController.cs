﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour {
	public static LevelController instance;
	private int score = 0;                      
	public bool gameOver = false;

	public float scrollSpeed = -1.5f;

	public UILabel scoreText;
	public UILabel highscoreText;
    public UILabel gameOverText;

	void Start() {
		gameOverText.enabled = false;
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	void FixedUpdate() {
		if (gameOver && (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)))
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void TomatoScored() {
		if (gameOver)   
			return;
		score++;
		scoreText.text = "бал: " + score.ToString();
	}

	public void TomatoCrushed() {
		gameOverText.enabled = true;
		gameOver = true;
	}
}