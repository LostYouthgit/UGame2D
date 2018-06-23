using UnityEngine;
using System.Collections;

public class Player2Beh : MonoBehaviour {

	public float speed = 10f;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
	
		rb = GetComponent <Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
		rb.MovePosition (rb.position + Vector2.left * speed * Time.deltaTime);
		//rb.Gravity = 10;
	}
}
