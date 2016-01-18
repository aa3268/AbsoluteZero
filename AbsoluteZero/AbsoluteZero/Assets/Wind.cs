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
		if (transform.position.x < 0 && GetComponent<Renderer>().IsVisibleFrom(Camera.main)) {

		}
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("A");
		col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.left * speed * 1000);
		col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * speed * 1000);
	}
}
