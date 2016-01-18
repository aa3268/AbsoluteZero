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
	// Use this for initialization
	void Start () {
		personal_color = personal_img.color;
		environment_color = environment_img.color;
	}
	
	// Update is called once per frame
	void Update () {
		Change (personal.value);
		personal.value -= Time.deltaTime;


	}

	void Change(float health)
	{
		if (health < 75 && health > 25) {
			if(personal_color.g < 175)
			{
				personal_color.g += (3.5f/255f);
			}
		}
		if (health < 25) {
			if(personal_color.b < 175)
			{
				if(personal_color.r > 0)
				{
					personal_color.r -= (17f/255f);
				}
				personal_color.b += (25f/255f);
			}
		}
		personal_img.color = personal_color;

	}
}
