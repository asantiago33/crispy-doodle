using UnityEngine;
using System.Collections;

public class Projectile_Behavior : MonoBehaviour {
	private Rigidbody rb;
	public float timer;
	private float timerValue;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		timerValue = timer;
	}
	void update() {
		Debug.Log ("Code Reached Here");
		if (timerValue > 0) {
			timerValue -= Time.deltaTime;

		} else {
			Destroy (this.gameObject);
		}
	}
	// Update is called once per frame
	void FixedUpdate() {
		float xVec = GameObject.Find ("Player").transform.position.x;
		float yVec = 0f;
		float zVec = GameObject.Find ("Player").transform.position.y;
		rb.AddForce (new Vector3(xVec, yVec, zVec));
	}


}
