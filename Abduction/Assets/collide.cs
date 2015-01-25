using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {

	public SpriteRenderer beam;
	// Use this for initialization
	void Start () {

	}
	public float floatHeight;
	public float liftForce;
	public float damping;
	void FixedUpdate() {

		if (beam.enabled) {
			RaycastHit2D hit = Physics2D.Raycast (transform.position, -Vector2.up, 5.5f);
			if (hit.collider != null) {
				if (hit.collider.tag != "Ground")
					hit.collider.rigidbody2D.AddForce(Vector2.up,ForceMode2D.Impulse);
				Debug.Log("hit");
			}
		}
	}
	
}
