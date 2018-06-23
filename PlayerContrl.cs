using UnityEngine;
using System.Collections;

public class PlayerContrl : MonoBehaviour {

	public float speed = 20f;
	private Rigidbody2D rb;

	private bool fall;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		float moveX = Input.GetAxis("Horizontal");
		rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);
		rb.AddForce (Vector2.up + 8000);
	}
}
