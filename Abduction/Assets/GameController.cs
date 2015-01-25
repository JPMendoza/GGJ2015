using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	//Object Variables
	private static int points;
	private static float timeLeft;
	private static bool gameOver;
	private static float stgWidth;
	private float nextActionTime; 
	public float period;
	public string[] prefabs;

	// Use this for initialization
	void Start () {
		points = 0;
		timeLeft = 30.0f;
		gameOver = false;
		stgWidth = 20.0f;

		//Spawner variables
		nextActionTime = 0.0f;
		period = 2.0f;
		prefabs = new string[8];
		prefabs[0] = "cow";
		prefabs[1] = "farmer";
		prefabs[2] = "civilian";
		prefabs[3] = "cop";
		prefabs[4] = "soldier";
		prefabs[5] = "car";
		prefabs[6] = "truck";
		prefabs[7] = "tank";

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

		if (!gameOver && Time.time > nextActionTime) {
			nextActionTime = Time.time + period;
			float side = 1.0f;
			float yVal = -2.0f;
			float zVal = 0.0f;
			float magnitude = Random.value * stgWidth;
			//Spawn prefabs within range
			if(Random.value < 0.5f){
				side *= -1;
			}

			float xVal = side * magnitude;

			//Randomly chooose a prefab
			int index = (int) Mathf.Floor(Random.value * prefabs.Length);
			string pName = prefabs[index];


			Debug.Log("X Position: " + xVal + " | Index: " + index);

			//Instantiate the prefab at the chosen location
			Instantiate(Resources.Load(pName), new Vector3 (xVal, yVal, zVal), Quaternion.identity);
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
