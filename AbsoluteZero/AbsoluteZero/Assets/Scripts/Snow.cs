using UnityEngine;
using System.Collections;

public class Snow : MonoBehaviour {

	public ParticleSystem snow;
	public Movement player;
	public float start;
	public float end;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player.gameObject.transform.position.x > start && player.gameObject.transform.position.x < end) {
			player.speed = 0.25f; 
		} else {
			player.speed = 0.5f;
		}


	}
}
