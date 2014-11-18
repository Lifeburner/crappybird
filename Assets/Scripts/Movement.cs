using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public GameObject otherScripts;

	void OnCollisionEnter2D(Collision2D coll)
	{
		Debug.Log(coll.gameObject.tag);
		if (coll.gameObject.tag == "Pillar") {
			GameOver();
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log(collider.ToString());
		if (collider != null && collider.gameObject.tag == "Point") {
			var myScript = otherScripts.GetComponent<Point> ();
			myScript.totalPoint += 1;
		}
	}

	private void GameOver ()
	{
		PlayerPrefs.SetInt("LastPoint",
		                   otherScripts.GetComponent<Point>().totalPoint);
		PlayerPrefs.Save();
		Application.LoadLevel("GameOver");
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log(transform.position.y.ToString());
		if (Input.GetKeyDown(KeyCode.Space)) {
			rigidbody2D.AddForce(new Vector2(0, 6f), ForceMode2D.Impulse);
		}

		if (transform.position.y < -4) {
			GameOver();
		}

	}
}
