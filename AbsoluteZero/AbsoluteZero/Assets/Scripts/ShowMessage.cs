using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowMessage : MonoBehaviour {


	public Text message;
	public float timer;

	public Color fadeIn;
	public Color fadeOut;

	public bool fade;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (fade) {
			FadeIn ();
		}
		else
		{
			FadeOut();
		}

	
	}

	public void PrintMessage(string mess)
	{
		message.text = mess;
		fade = true;
	}

	void FadeIn()
	{
		fadeIn = message.color;
		timer -= Time.deltaTime;
		if (fadeIn.a < 1.1) {
			fadeIn.a += Time.deltaTime;
			message.color = fadeIn;
		} else {
			if(timer < 0)
			{
				fade = false;
			}
		}
	}

	void FadeOut()
	{
		fadeOut = message.color;
		
		if (fadeOut.a > 0) {
			fadeOut.a -= Time.deltaTime;
			message.color = fadeOut;
		}
		else
		{
			timer = 5f;
		}
	}


}
