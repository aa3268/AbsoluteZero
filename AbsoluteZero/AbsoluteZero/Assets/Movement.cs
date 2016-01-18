using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movement : MonoBehaviour {

	[Range(0.1f,0.5f)]
	public float speed = 0.1f;

	public Rigidbody2D body;
	public SpriteRenderer sr;
	public bool canJump;
	public float force;

	public Animator anim;
	public Sprite jump;
	public Sprite idle;
	public Sprite frozen;

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
				if (transform.position.y < -3.48) {
					anim.enabled = true;
					anim.Play ("walk");
				}
				transform.Translate (Vector3.right / 5 * speed);
				transform.localScale = new Vector3 (1f, 1f, 1f);

			}
			if (Input.GetKey (KeyCode.A)) {
				if (transform.position.y < -3.48) {
					anim.enabled = true;
					anim.Play ("walk");
				}
				transform.Translate (Vector3.left / 5 * speed);
				transform.localScale = new Vector3 (-1f, 1f, 1f);
			}

			if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
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
		}
	}


	void Health()
	{
		if (health.value == 0) {
			sr.sprite = frozen;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("Floor")) {
				canJump = true;
			sr.sprite = idle;
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
	}
}
