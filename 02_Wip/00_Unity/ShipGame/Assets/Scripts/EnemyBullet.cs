using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

	Vector3 direction;
	Rigidbody rb;
	public float BulletSpeed;
	//public GameObject Player;
	public GameObject Launcher;

	// Use this for initialization
	void Start()
	{
		float vX = 4f * Time.deltaTime;
		transform.Translate(Launcher.transform.up * vX);
		direction = Launcher.transform.up;
		/*rb = GetComponent<Rigidbody>();
		rb.AddRelativeForce(0, 0, BulletSpeed, ForceMode.Impulse);*/
	}

	void Update()
	{
		//Speed and direction of the bullet
		float vX = 3f * Time.deltaTime;
		transform.Translate(direction * vX);
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			Destroy(gameObject, 0);
		}

		if (collision.gameObject.tag == "Wall")
		{
			Destroy(gameObject, 0);
		}
	}

}
