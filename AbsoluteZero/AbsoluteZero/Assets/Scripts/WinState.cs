using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinState : MonoBehaviour {

	public GameObject id;
	public ShowMessage show;
	public GameObject canvas;
	public Text message;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (id.gameObject != null) {
			show.PrintMessage ("You need your ID to get in.");
		} else {
			message.text = "You survived the harsh weather!"+ '\n' + " (But failed the harsh exam)";
			canvas.gameObject.SetActive(true);

		}

	}
}
