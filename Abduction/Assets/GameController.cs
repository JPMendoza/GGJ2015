using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//Object Variables
	private static int points;
	private static float timeLeft;
	private static bool gameOver;

	// Use this for initialization
	void Start () {
		points = 0;
		timeLeft = 10.0f;
		gameOver = false;

		DontDestroyOnLoad(transform.gameObject);
	}

	void OnGUI () {
		if (gameOver) {
			GUI.Label(new Rect(60,10,100,30), "GAME OVER");
		}

		else {
    		GUI.Label(new Rect(60,10,100,30), "Timer: " + System.Math.Round(timeLeft, 2));
		}

		//Score GUI Label
		GUI.Label(new Rect(60,40,100,30), "Score: " + points);
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;


		if (timeLeft <= 0){
			Debug.Log("Game Over!!!");
			GameOver();
		}
	
	}

	public static void GameOver() {
		if(!gameOver) {
			Application.LoadLevel("GameOver");
			gameOver = true;
		}
	}

	public static void addPoints(int num) {
		points += num;
		Debug.Log("Points: " + points);
	}



}
