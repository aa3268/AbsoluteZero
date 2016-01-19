using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {

	public bool colliding;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Player"))
		{
			colliding = true;
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Player")) {
			colliding = false;
		}
	}
}
