using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {
	public float speed;

	Transform camera;
	Transform[] copies;
	float view = 1.0f;
	int left;
	int right;

	private Rigidbody2D myBody;
	private BoxCollider2D сollide;

	/*public*/ float size;

	void Awake () {
		сollide = GetComponent<BoxCollider2D> ();
		size = сollide.size.x;
		camera = Camera.main.transform;
		copies = new Transform[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
			copies[1] = transform.GetChild(i);
		left = 0;
		right = copies.Length - 1;
		myBody = GetComponent<Rigidbody2D>();
        myBody.velocity = new Vector2 (-(speed), 0);
	}

	void Start () {}

	void FixedUpdate () {
		if(LevelController.instance.gameOver == true)
			myBody.velocity = Vector2.zero;
		if (transform.position.x < -(size * 2.0f)) {
			Vector2 offset = new Vector2(size * 2.0f, 0);
			transform.position = (Vector2) transform.position + offset;
		}		
	}
}
