using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveKill : MonoBehaviour {

	public bool EnemySquare = false;
	private int LifeSquare = 1;
	public bool EnemyPentagon = false;
	private int LifePentagon = 1;
	public bool EnemyHexagon = false;
	private int LifeHexagon = 2;
	public bool EnemyOctagon = false;
	private int LifeOctagon = 2;
	public bool EnemyDodecagon = false;
	private int LifeDodecagon = 3;
	public bool EnemyDouble = false;
	private int LifeDouble = 4;
	public bool EnemyShot = false;
	private int LifeShot = 3;

	//public int Damage = 0;

	public GameObject Square1;
	public GameObject Father;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		//Set damage
		/*
		if (WaveEnemySpawner.Wave == 0)
		{
			Damage = 1;
		}
		if (WaveEnemySpawner.Wave == 2)
		{
			Damage = 2;
		}
		if (WaveEnemySpawner.Wave >= 3)
		{
			Damage = 3;
		}*/

		//When enemies die

		if (LifeSquare <= 0)
		{
			WaveEnemySpawner.EnemiesNumber -= 1;
			Destroy(this.gameObject);
		}
		if (LifePentagon <= 0)
		{
			WaveEnemySpawner.EnemiesNumber -= 1;
			Destroy(this.gameObject);
		}
		if (LifeOctagon <= 0)
		{
			WaveEnemySpawner.EnemiesNumber--;
			Destroy(this.gameObject);
		}
		if (LifeHexagon <= 0)
		{
			WaveEnemySpawner.EnemiesNumber--;
			Destroy(this.gameObject);
		}
		if (LifeDodecagon <= 0)
		{
			WaveEnemySpawner.EnemiesNumber--;
			Destroy(this.gameObject);
		}
		if (LifeDouble <= 0)
		{
			GameObject clone1 = Instantiate(Square1, Father.transform.position, Quaternion.identity) as GameObject;
			clone1.SetActive(true);
			WaveEnemySpawner.EnemiesNumber--;
			Destroy(Father);
		}
		if (LifeShot <= 0)
		{
			WaveEnemySpawner.EnemiesNumber--;
			Destroy(this.gameObject);
		}
	}

	//When the bullet hit an enemy it lose health and destroy the bullet

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (EnemySquare)
		{
			if (collision.gameObject.tag == "Bullet")
			{
				LifeSquare -= WaveEnemySpawner.Damage;
				Destroy(collision.gameObject);
			}
		}
		if (EnemyPentagon)
		{
			if (collision.gameObject.tag == "Bullet")
			{
				LifePentagon -= WaveEnemySpawner.Damage;
				Destroy(collision.gameObject);
			}
		}
		if (EnemyOctagon)
		{
			if (collision.gameObject.tag == "Bullet")
			{
				LifeOctagon -= WaveEnemySpawner.Damage;
				Destroy(collision.gameObject);
			}
		}
		if (EnemyHexagon)
		{
			if (collision.gameObject.tag == "Bullet")
			{
				LifeHexagon -= WaveEnemySpawner.Damage;
				Destroy(collision.gameObject);
			}
		}
		if (EnemyDodecagon)
		{
			if (collision.gameObject.tag == "Bullet")
			{
				LifeDodecagon -= WaveEnemySpawner.Damage;
				Destroy(collision.gameObject);
			}
		}
		if (EnemyDouble)
		{
			if (collision.gameObject.tag == "Bullet")
			{
				LifeDouble -= WaveEnemySpawner.Damage;
				Destroy(collision.gameObject);
			}
		}
		if (EnemyShot)
		{
			if (collision.gameObject.tag == "Bullet")
			{
				LifeShot -= WaveEnemySpawner.Damage;
				Destroy(collision.gameObject);
			}
		}
	}
}
