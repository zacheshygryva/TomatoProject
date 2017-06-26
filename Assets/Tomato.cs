using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour {
	public float jump = 300f;
	bool dead = false;
	float wait = 0.0f;

	Rigidbody2D myBody;

	void Start () {
		myBody = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () {
		if (dead)
			wait -= Time.deltaTime;
		else
			if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) {
				myBody.velocity = Vector2.zero;
				myBody.AddForce(new Vector2(0, jump));
			}
		
	}
	
	void OnCollisionEnter2D () {
		die();
	}

	void die() {
		wait += 1.5f;
		dead = true;
	}
}
