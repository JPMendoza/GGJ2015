using UnityEngine;
using System.Collections;

public class GameOverController : MonoBehaviour {

	//Object Variables
	private static int points;

	// Use this for initialization
	void Start () {
		points = 0;
	}

	void OnGUI () {
		GUI.Label(new Rect(60,10,100,30), "GAME OVER");

		//Score GUI Label
		GUI.Label(new Rect(60,40,100,30), "Score: " + points);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
