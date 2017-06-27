using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectable : MonoBehaviour {

	void Awake () {
		float r = Random.Range(0,5);
		if (r == 2) this.gameObject.SetActive(true);
		else this.gameObject.SetActive(false);

	}
}
