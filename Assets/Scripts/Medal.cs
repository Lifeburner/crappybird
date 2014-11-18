using UnityEngine;
using System.Collections;

public class Medal : MonoBehaviour {

	public Sprite goldMedal;
	public Sprite silverMedal;
	public Sprite bronzeMedal;

	private int _point;
	private Sprite _medal;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("LastPoint")) {
			_point = PlayerPrefs.GetInt("LastPoint");
		}
		else Debug.Log("Key not found.");

		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

		ShowMedal();
	}

	void ShowMedal()
	{
		if (_point < 5) {
			_medal = bronzeMedal;
		}
		else if (_point >= 5 && _point < 10) {
			_medal = silverMedal;
		}
		else _medal = goldMedal;

		spriteRenderer.sprite = _medal;
	}

	IEnumerator FadeIn()
	{
		float alpha;
		for (int i = 0; i <= 100; i++) {
			alpha = i / 100f;
			spriteRenderer.color = new Color(255, 255, 255, alpha);
			yield return null;
		}
	}

	void Update()
	{
		StartCoroutine(FadeIn());
	}
}
