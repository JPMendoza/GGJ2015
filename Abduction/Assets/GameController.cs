using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//Object Variables
	private static int points;
	private static float timeLeft;

	// Use this for initialization
	void Start () {
		points = 0;
		timeLeft = 10.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0){
			Debug.Log("Game Over!!!");
			//GameOver();
		}
	
	}

	public static void addPoints(int num) {
		points += num;
		Debug.Log("Points: " + points);
	}



}
