﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavePlayerController : MonoBehaviour {

	public static Vector2 Position;

	public float moveSpeed = 2f;
	public float moveSmooth = .3f;

	private Rigidbody2D rb;

	Vector2 movement = Vector2.zero;
	Vector2 velocity = Vector2.zero;

	Vector2 mousePos = Vector2.zero;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		movement.x = Input.GetAxisRaw("Horizontal");
		movement.y = Input.GetAxisRaw("Vertical");

		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


		Vector2 desiredVelocity = movement * moveSpeed;
		rb.velocity = Vector2.SmoothDamp(rb.velocity, desiredVelocity, ref velocity, moveSmooth);

		Vector2 lookDir = mousePos - rb.position;

		rb.rotation = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;

		Position = rb.position;
	}
}
