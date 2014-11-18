using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject prefab;
	public float time;
	public float minColumn;
	public float maxColumn;
	public float minPillar;
	public float maxPillar;
	private float _totalTime;

	// Use this for initialization
	void Start () {
		time = 2.0f;
		minColumn = -1.5f;
		maxColumn = 1.5f;
		minPillar = 3.6f;
		maxPillar = 4.0f;
	}
	
	private void GenerateColumn ()
	{
		Transform[] pillars;
		float randomFloat = Random.Range(minPillar, maxPillar);
		GameObject pillar = Instantiate(prefab, new Vector3(6, Random.Range(minColumn, maxColumn), 0),
		                                Quaternion.identity) as GameObject;

		pillars = pillar.GetComponentsInChildren<Transform>();
		foreach (Transform column in pillars) {
			if (column.name == "PillarUp") {
				column.transform.localPosition = new Vector3(0, randomFloat, 0);
				//Debug.Log("Upper pillar set");
			}
			else if (column.name == "PillarDown") {
				column.transform.localPosition = new Vector3(0, -randomFloat, 0);
				//Debug.Log("Lower pillar set");
			}
		}
	}

	// Update is called once per frame
	void Update () {
		_totalTime += Time.deltaTime;
		if (_totalTime >= time) {
			_totalTime = 0;
 			GenerateColumn();
		}
	}
}
