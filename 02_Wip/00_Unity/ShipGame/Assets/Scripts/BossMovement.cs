using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {

	public float vX = 4f;
	public bool DirectionLeft = true;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//-0.899  0.951 * Time.deltaTime
		/*if (gameObject.transform.position.x <= 0f && gameObject.transform.position.x >= -0.899f)
		{
			transform.Translate(gameObject.transform.right * -vX);
		}*/
		if (DirectionLeft)
		{
			transform.Translate(gameObject.transform.right * -vX);
		}else if (!DirectionLeft)
		{
			transform.Translate(gameObject.transform.right * vX);
		}
	}
	/*
	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "WallLeft")
		{
			DirectionLeft = false;
		}
		if (collision.gameObject.name == "WallRight")
		{
			DirectionLeft = true;
		}
	}*/
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "WallLeft")
		{
			DirectionLeft = false;
		}
		if (collision.gameObject.name == "WallRight")
		{
			DirectionLeft = true;
		}
	}
}
