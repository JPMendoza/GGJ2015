using UnityEngine;
using System.Collections;

public class SpaceShipController : MonoBehaviour {
	
	public float maxSpeed = 10.0f;
	public SpriteRenderer beam;

	// Use this for initialization
	void Start () {
		beam.enabled = false;
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		rigidbody2D.velocity = new Vector2 (moveHorizontal * maxSpeed, moveVertical * maxSpeed);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			beam.enabled = true;

		} else {
			beam.enabled = false;		
		}

		if (Input.GetKey("left")) {
			if (rigidbody2D.rotation < 30){
				rigidbody2D.rotation += 2;
			}
		}
		else if (Input.GetKey("right")){
			if (rigidbody2D.rotation > -30){
				rigidbody2D.rotation -= 2;
			}
		}
		//Get back to zero
		else {
			float rot = rigidbody2D.rotation;
			if (rot < 0) {
				rigidbody2D.rotation += 1;
			}
			else if (rot > 0) {
				rigidbody2D.rotation -= 1;
			}
		}
	
	}
}
