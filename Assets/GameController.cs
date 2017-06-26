using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour{
	public static GameController instance;         
	public Text scoreText;                      
	public GameObject gameOvertext;             

	private int score = 0;                      
	public bool gameOver = false;               
	public float scrollSpeed = -1.5f;


	void Start(){
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy (gameObject);
	}

	void Restart(){
		if (gameOver && Input.GetMouseButtonDown(0)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	public void TomatoScored(){
		if (gameOver)   
			return;
		score++;
		scoreText.text = "Score: " + score.ToString();
	}

	public void TomatoCrushed(){
		gameOvertext.SetActive (true);
		gameOver = true;
	}
}