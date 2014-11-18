using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	public int totalPoint;
	// Use this for initialization
	void Start () {
		totalPoint = 0;
	}

	void OnGUI ()
	{
		GUI.color = Color.black;
		GUI.Label(new Rect(10, 10, 100, 30), totalPoint.ToString());
	}

	// Update is called once per frame
	void Update () {
		Debug.Log(totalPoint.ToString());
	}
}
