using UnityEngine;
using System.Collections;

public class Pillar : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.position -= new Vector3 (0.025f, 0, 0);
		if (transform.position.x < -6) {
			Destroy(this.gameObject);
				}
	}
}
