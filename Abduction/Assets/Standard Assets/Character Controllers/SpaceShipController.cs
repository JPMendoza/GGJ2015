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
	
	}
}
