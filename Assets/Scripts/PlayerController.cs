﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	// Start is called during the first frame that this script is accessed during the game
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called before rendering a frame
//	void Update ()
//	{
//		
//	}

	// FixedUpdate is called just before performing any physics calculations
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}
