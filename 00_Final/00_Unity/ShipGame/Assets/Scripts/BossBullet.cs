using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour {

	Vector3 direction;
	Rigidbody rb;
	public float BulletSpeed;
	public int BulletID;
	public GameObject Launcher1;
	public GameObject Launcher2;
	public GameObject Launcher3;

	// Use this for initialization
	void Start()
	{
		if (BulletID == 1){
			float vX = 1f * Time.deltaTime;
			transform.Translate(Launcher1.transform.up * -vX);
			direction = Launcher1.transform.up;
		}
		if (BulletID == 2)
		{
			float vX = 1f * Time.deltaTime;
			transform.Translate(Launcher2.transform.up * vX);
			direction = Launcher2.transform.up;
		}
		if (BulletID == 3)
		{
			float vX = 1f * Time.deltaTime;
			transform.Translate(Launcher3.transform.up * vX);
			direction = Launcher3.transform.up;
		}
	}

	void Update()
	{
		//Speed and direction of the bullet
		if (BulletID == 1)
		{
			float vX = 1f * Time.deltaTime;
			transform.Translate(direction * -vX);
		}
		if (BulletID == 2)
		{
			float vX = 1f * Time.deltaTime;
			transform.Translate(direction * vX);
		}
		if (BulletID == 3)
		{
			float vX = 1f * Time.deltaTime;
			transform.Translate(direction * vX);
		}
		if (gameObject.transform.position.y <= -3.033f)
		{
			Destroy(gameObject);
		}
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject, 0);
		}
	}
}
