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
		//Don't let the ship go below 0 on the Y axis
		Vector3 t = transform.position;

		if (t.y <= 0) {
			Debug.Log("Flying too low!");
			transform.position = new Vector3 (t.x, 0.1f, t.z);
		}


		if (Input.GetKey (KeyCode.Space)) {
			beam.enabled = true;

		} else {
			beam.enabled = false;		
		}

		if (Input.GetKey("left") || Input.GetKey("a")) {
			if (rigidbody2D.rotation < 30){
				rigidbody2D.rotation += 2;
			}
		}
		else if (Input.GetKey("right") || Input.GetKey("d")){
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
