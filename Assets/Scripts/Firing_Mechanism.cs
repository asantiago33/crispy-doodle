using UnityEngine;
using System.Collections;

public class Firing_Mechanism : MonoBehaviour {
	// Use this for initialization
	public GameObject projectile;
	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			float xPos = GameObject.Find ("Player").transform.position.x;
			float zPos = GameObject.Find ("Player").transform.position.z;
			float yPos = GameObject.Find ("Player").transform.position.y;
			GameObject.Instantiate (projectile, new Vector3(xPos, yPos + 3f, zPos), Quaternion.identity);
		}
	}
}
