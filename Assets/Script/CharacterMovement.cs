<<<<<<< HEAD
﻿using System.Collections;
=======
using System.Collections;
>>>>>>> programador2
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

<<<<<<< HEAD
	public float maxSpeed = 6.0f;
	public bool facingRight = true;
	public float moveDirection;
	private Rigidbody rigidbody;
	
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent <Rigidbody> ();
=======
	public bool facingRight = true;
	public float moveDirection;
	
	
	// Use this for initialization
	void Start () {
		
>>>>>>> programador2
	
	}
	
	// Update is called once per frame
<<<<<<< HEAD
	void Update () {
		moveDirection = Input.GetAxis ("Horizontal");

	}
	void FixedUpdate () {
		rigidbody.velocity = new Vector2 (moveDirection * maxSpeed, rigidbody.velocity.y);
	}
=======
    
	void Update () {
		moveDirection = Input.GetAxis ("Horizontal");

		
	}

	void FixedUpdate () {
		if (moveDirection > 0.0f && !facingRight) {
			Flip ();
		} else if (moveDirection < 0.0f && facingRight) {
			Flip ();
		}

	}
    
	void Flip() {
		facingRight = !facingRight;
		transform.Rotate (Vector3.up, 180.0f, Space.World);
	}


>>>>>>> programador2
}
