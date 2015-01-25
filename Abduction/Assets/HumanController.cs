using UnityEngine;
using System.Collections;

public class HumanController : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//Check RigidBody Velocity, if it's above a certain amount then set floating to true
		Vector3 t = transform.position;

		if(t.y > -3.0f){
			animator.SetBool("floating", true);
		}
		else{
			animator.SetBool("floating", false);
		}
	}
}
