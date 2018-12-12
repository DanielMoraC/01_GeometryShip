using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

	public int disparando = 1;
	public Transform Player;
	public GameObject weapon;
	public Transform gunEnd;
	public int seconds;


	// Use this for initialization
	void Awake()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

	}

	//Detect if the player is in range of the enemie for it to shot
	public void OnTriggerStay2D(Collider2D collision)
	{		
		if (collision.gameObject.tag == "Player" && disparando == 1)
		{
			StartCoroutine("Shooting");
		}
	}

	//Detect id the player exit the range of the enemie
	public void OnTriggerExit2D(Collider2D collision)
	{		
		if (collision.gameObject.tag == "Player")
		{
			StopCoroutine("Shooting");
			disparando = 1;
		}
	}
	
	//Make the enemie shot
	public IEnumerator Shooting()
	{
		disparando = 0;
		GameObject clone = Instantiate(weapon, gunEnd.position, gunEnd.rotation);
		clone.SetActive(true);
		yield return new WaitForSeconds(seconds);
		disparando = 1;
	}
}
