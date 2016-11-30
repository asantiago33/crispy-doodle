using UnityEngine;
using System.Collections;

public class Projectile_Behavior : MonoBehaviour {
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		float xVec = GameObject.Find ("Player").transform.position.x;
		float yVec = 0f;
		float zVec = GameObject.Find ("Player").transform.position.y;
		rb.AddForce (new Vector3(xVec, yVec, zVec));
	}
}
