using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {
	public int value = 5;

	void OnTriggerEnter2D(Collider2D collider) {
		Tomato tomato = collider.GetComponent<Tomato>();
		if (tomato != null) {
			LevelController.instance.TomatoScored();
			Destroy (this.gameObject);
		}
	}

}
