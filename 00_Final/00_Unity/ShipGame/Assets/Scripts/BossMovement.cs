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

		//Boss movment from left to right and right to left
		if (DirectionLeft)
		{
			transform.Translate(gameObject.transform.right * -vX);
		}else if (!DirectionLeft)
		{
			transform.Translate(gameObject.transform.right * vX);
		}
	}
	
	//If the boss collide with a wall it goes to the other side
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
