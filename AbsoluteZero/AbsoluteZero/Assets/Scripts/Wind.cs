using UnityEngine;
using System.Collections;

public class Wind : MonoBehaviour {


	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * speed);
		if (transform.position.x < -50) {
			Destroy(gameObject);
		}
	}
}
