using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	private int pointVal;

	// Use this for initialization
	void Start () {
		string nm = gameObject.name;

		nm = nm.Replace("(Clone)", "");

		switch (nm){
			case "cow":
				pointVal = 10;
				rigidbody2D.mass = 3;
				break;
			case "farmer":
				pointVal = 20;
				break;
			case "civilian":
				pointVal = 30;
				break;
			case "cop":
				pointVal = 40;
				break;
			case "car":
				pointVal = 50;
				rigidbody2D.mass = 4;
				break;
			case "truck":
				pointVal = 70;
				rigidbody2D.mass = 4.5f;
				break;
			case "soldier":
				pointVal = 100;
				break;
			case "tank":
				pointVal = 200;
				rigidbody2D.mass = 5;
				break;
			default:
				pointVal = 0;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Handle collision with Ship
	void OnCollisionEnter2D (Collision2D col) {
       if(col.gameObject.name == "ship"){
       		GameController.addPoints(pointVal);
        	Destroy(gameObject);
       }
    }
}
