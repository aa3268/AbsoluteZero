using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TempBehavior : MonoBehaviour {



	public Slider personal;
	public Slider environment;

	public Color personal_color;
	public Color environment_color;

	public Image personal_img;
	public Image environment_img;

	public float multiplier;
	public float timer;
	public float temp;
	public bool start;
	// Use this for initialization
	void Start () {
		personal_color = personal_img.color;
		environment_color = environment_img.color;
		timer = 10f;
		start = true;
	}
	
	// Update is called once per frame
	void Update () {
		personal.value -= (multiplier * Time.deltaTime)/(environment.value);
		if (start) {
			timer -= 0.01f;
		}
		SetRandTemp();
		ChangeTemp ();
	}

	void SetRandTemp()
	{
		if (timer < 0 && start) {
			temp = 1 + Random.value;
			temp = Mathf.Round(temp * 100f) / 100f;
			start = false;
		}
	}

	void ChangeTemp()
	{
		if (timer < 0) {
			if(environment.value < temp)
			{
				environment.value += 0.01f;
				environment.value = Mathf.Round(environment.value * 100f) / 100f;
			}
			else
			{
				environment.value -= 0.01f;
				environment.value = Mathf.Round(environment.value * 100f) / 100f;
			}
			if (environment.value == temp) {
				timer = 10f;
				start = true;
			}
		}


	}
}
