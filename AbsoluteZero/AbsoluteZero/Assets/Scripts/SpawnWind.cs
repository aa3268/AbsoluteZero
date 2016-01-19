using UnityEngine;
using System.Collections;

public class SpawnWind : MonoBehaviour {

	public int ran;
	public GameObject wind;
	public float timer;
	public float initial;
	// Use this for initialization
	void Start () {
		timer = initial;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			ran = Mathf.RoundToInt (Random.value * 100f);
			if (ran < 35) {
				Instantiate (wind, transform.position, wind.transform.rotation);
			}
			timer = initial;
		}
		timer -= Time.deltaTime;
	}
}
