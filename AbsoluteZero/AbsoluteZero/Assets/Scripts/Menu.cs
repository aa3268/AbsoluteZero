using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

	public GameObject canvas;
	public Button restart;
	public Button main;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Quit()
	{
		if (Cursor.visible) {
			Application.Quit ();
		}
	}

	public void First()
	{
		if (restart.interactable) {
			Application.LoadLevel (1);
		}
	}

	public void Main()
	{
		if (main.interactable) {
			Application.LoadLevel (0);
		}
	}
}
