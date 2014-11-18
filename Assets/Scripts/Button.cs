using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	void OnMouseDown()
	{
		if (gameObject.name == "StartButton") {
			Application.LoadLevel("Play");
		}
		else if (gameObject.name == "ExitButton") {
			Application.Quit();
		}
	}

}
