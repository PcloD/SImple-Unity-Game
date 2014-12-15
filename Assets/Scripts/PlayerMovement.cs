using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	
	private Vector3 input;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
//	void Update () {
//
//	}

	void Update () {
		input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

		if (rigidbody.velocity.magnitude < 4) {
			rigidbody.AddForce (input * speed * 1.5f);

		} else if (rigidbody.velocity.magnitude > 4){
			rigidbody.AddForce (input * speed);

		}
	}
}
