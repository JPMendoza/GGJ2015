using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Handle collision with Ship
	void OnCollisionEnter2D (Collision2D col) {
       if(col.gameObject.name == "ship"){
       		GameController.addPoints(10);
        	Destroy(gameObject);
       }
    }
}
