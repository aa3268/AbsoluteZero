using UnityEngine;
using System.Collections;

public class TransitionManager : MonoBehaviour {


	public Transition left;
	public Transition right;

	public Collider2D next;
	public Collider2D prev;


	public Vector3 camV;
	public Camera cam;

	public float rightPos;
	public float leftPos;

	public float pl;
	public float pr;
	public Vector3 pV;
	public bool start;
	public GameObject player;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (right.colliding) {
			start = true;
			camV = cam.transform.position;
			camV.x = rightPos; 

			pV = player.transform.position;
			pV.x = pr;
		}
		if (left.colliding) {
			start = true;
			camV = cam.transform.position;
			camV.x = leftPos; 

			pV = player.transform.position;
			pV.x = pl;
		}

		if (start) {
			cam.transform.position = Vector3.Lerp(cam.transform.position, camV, Time.deltaTime);
		}
		if(camV.x == rightPos)
		{
			if(cam.transform.position.x <= rightPos - 0.2)
			{
				player.transform.position = Vector3.Lerp(cam.transform.position, pV, Time.deltaTime);
			}
		}

	}
}
