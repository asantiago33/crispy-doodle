using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float rotate = Input.GetAxis ("Rotate");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		Vector3 rotation = new Vector3 (0f, rotate, 0f);
		Debug.Log ("Code Reached Here!");
		rb.AddTorque (rotation * speed);
		rb.AddForce (movement * speed);
	}
}
