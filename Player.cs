﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

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
		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (Vector2.up * 2000);
	}
}
