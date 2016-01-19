using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {


	public float stopLeft;
	public float stopRight;
	public GameObject player;
	public Vector3 reset;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (player.transform.position.x < stopLeft || player.transform.position.x > stopRight) {

			transform.parent = null;
		} else {

			transform.parent = player.transform;
			reset = transform.position;
			reset.y = 0;
			transform.position = reset;
		}

	}
}
