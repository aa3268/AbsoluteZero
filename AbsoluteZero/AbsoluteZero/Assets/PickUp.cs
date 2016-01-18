using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUp : MonoBehaviour {

	public Slider personal;

	public float amount;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Player")) {
			if (personal.value <= personal.maxValue - amount) {
				personal.value += amount;
			} else {
				personal.value += personal.maxValue - personal.value;

			}
			Destroy (gameObject);
		}
	}
}
