using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveHealth : MonoBehaviour {

	public int health = 3;

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;

	Renderer rend;

	public int level;

	// Use this for initialization
	void Start()
	{
		rend = GetComponent<Renderer>();
	}

	//Die
	void Update()
	{
		if (health == 0)
		{
			Die();
		}
	}

	//Take damage from enemies

	private void OnCollisionEnter2D(Collision2D collision)
	{

		#region Square
			if (collision.gameObject.tag == "Square")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion Square

			#region Pentagon
			if (collision.gameObject.tag == "Pentagon")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion Pentagon

			#region Hexagon
			if (collision.gameObject.tag == "Hexagon")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion Hexagon

			#region Octagon
			if (collision.gameObject.tag == "Octagon")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion Octagon

			#region Dodecagon
			if (collision.gameObject.tag == "Dodecagon")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion Dodecagon

			#region Double
			if (collision.gameObject.tag == "Double")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion Double

			#region Shot
			if (collision.gameObject.tag == "Shot")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion Shot

			#region ShotBullet
			if (collision.gameObject.tag == "ShotBullet")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion ShotBullet

			#region BossBullet
			if (collision.gameObject.tag == "BossBullet")
			{
				if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion BossBullet
		
	}

	public virtual void Die()
	{
		SceneManager.LoadScene("Defeat");
	}

	//Deactivate the hearts when the player get damages

	public virtual void HitDamage()
	{
		if (health == 2)
		{
			heart3.SetActive(false);
		}
		else if (health == 1)
		{
			heart2.SetActive(false);
		}
	}

	//When you get hit the player sprite is red

	IEnumerator Hit()
	{
		rend.material.color = Color.red;
		yield return new WaitForSeconds(0.5f);
		rend.material.color = Color.white;
	}
}
