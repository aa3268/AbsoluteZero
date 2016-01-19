using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movement : MonoBehaviour {

	[Range(0.1f,0.5f)]
	public float speed = 0.1f;

	public Rigidbody2D body;
	public SpriteRenderer sr;
	public bool canJump;
	public bool goUp;
	public bool goDown;
	public float force;
	public Button restart;
	public Button main;

	public Animator anim;
	public Sprite jump;
	public Sprite idle;
	public Sprite block;

	public Sprite frozenJ;
	public Sprite frozenI;
	public Sprite frozenW;

	public Slider health;
	public Canvas gameOver;
	// Use this for initialization
	void Start () {
		anim.enabled = false;
		sr.sprite = idle;

	}
	
	// Update is called once per frame
	void Update () {
		if (!gameOver.isActiveAndEnabled) {
			if (Input.GetKey (KeyCode.D)) {
				anim.enabled = true;
				anim.Play ("walk");

				transform.Translate (Vector3.right / 5 * speed);
				transform.localScale = new Vector3 (1f, 1f, 1f);
				if(goUp)
				{
					transform.Translate (Vector3.up / 5 * speed);
				}
				if(goDown)
				{
					transform.Translate (Vector3.down / 5 * speed);
				}

			}
			if (Input.GetKey (KeyCode.A)) {


				anim.enabled = true;
				anim.Play ("walk");
				transform.Translate (Vector3.left / 5 * speed);
				transform.localScale = new Vector3 (-1f, 1f, 1f);
				if(goUp)
				{
					transform.Translate (Vector3.up / 5 * speed);
				}
				if(goDown)
				{
					transform.Translate (Vector3.down / 5 * speed);
				}
			}

			if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
				anim.enabled = false;
				sr.sprite = idle;
			}

			if (Input.GetKeyDown (KeyCode.LeftShift)) {
				anim.enabled = false;
				sr.sprite = block;
			}
			if (Input.GetKeyUp (KeyCode.LeftShift)) {
				anim.enabled = false;
				sr.sprite = idle;
			}

			if (Input.GetKeyDown (KeyCode.Space) && canJump) {
				anim.enabled = false;
				sr.sprite = jump;
				body.AddForce (Vector3.up * force);
			}
		}
			Health ();
		if (health.value == 0) {
			gameOver.gameObject.SetActive(true);
			restart.interactable = true;
			main.interactable = true;
		}
	}


	void Health()
	{
		if (health.value == 0) {
			Debug.Log(sr.sprite.name);
			if(sr.sprite.name.Equals("AbsoluteZero_Sprites_0") || sr.sprite.name.Equals(frozenI.name))
		    {
				Debug.Log("A");
				sr.sprite = frozenI;
			}
			else if(sr.sprite.name.Equals("AbsoluteZero_Sprites_3") || sr.sprite.name.Equals(frozenJ.name))
			{
				Debug.Log("B");
				sr.sprite = frozenJ;
			}
			else
			{
				sr.sprite = frozenW;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Floor") ||col.gameObject.tag.Equals ("Stairs") ) {
				canJump = true;
			sr.sprite = idle;
		}
		if (col.gameObject.tag.Equals ("Stairs")) {
			goUp = true;
		}


	}
	
	void OnCollisionStay2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Floor")) {

			if(!anim.enabled && !canJump)
			{
				canJump = true;
			}
		}
	}

	void OnCollisionExit2D(Collision2D col)
	{
		canJump = false;
		if(col.gameObject.tag.Equals("Stairs"))
		{
			goUp = false;
		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag.Equals ("Wind")) {
			body.AddForce (Vector3.left * speed * 500);
			body.AddForce (Vector3.up * speed * 500);
			
			if(!sr.sprite.name.Equals("AbsoluteZero_Sprites_4"))
			{
				health.value -= 20;
			}
			col.gameObject.GetComponent<Collider2D>().enabled = false;
		}
	}

}
