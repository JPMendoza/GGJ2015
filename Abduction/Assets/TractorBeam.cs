using UnityEngine;
using System.Collections;

public class TractorBeam : MonoBehaviour {

	public Transform top, bottom;

			// Prefab of the rocket.
	public SpriteRenderer beam;
		// Use this for initialization
	void Start () {
		beam = Instantiate(beam, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as SpriteRenderer;
		beam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		//beam.transform.position.x += beam.transform.parent.position.x;
		//beam.transform.position.y += beam.transform.parent.position.y;
		if (Input.GetKeyDown (KeyCode.Space)) {
			beam.enabled = true;
		} else {
			beam.enabled = false;		
		}
	}

	void Raycasting() {
		Debug.DrawLine (top.position, bottom.position, Color.blue);
	}
}
