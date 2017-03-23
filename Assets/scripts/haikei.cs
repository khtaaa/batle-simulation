using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haikei : MonoBehaviour {
	void Update () {
            transform.Translate(-0.05f, 0, 0);
		if (transform.position.x < -18.5f ) {
			transform.position = new Vector3 (18.5f, 0, 1);
		}
	}
}
