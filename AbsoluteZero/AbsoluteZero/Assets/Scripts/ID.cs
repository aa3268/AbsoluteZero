using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ID : MonoBehaviour {

	public ShowMessage show;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name.Equals ("Player")) {
			show.PrintMessage("You have found your ID");
			Destroy(gameObject);
		}
	}
}
