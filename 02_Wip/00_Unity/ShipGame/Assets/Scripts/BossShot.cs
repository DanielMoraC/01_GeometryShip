using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShot : MonoBehaviour {

	public int disparando = 1;
	public GameObject weapon;
	public GameObject weapon2;
	public GameObject weapon3;
	public Transform gunEnd;
	public Transform gunEnd2;
	public Transform gunEnd3;


	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (disparando == 1)
		{
			StartCoroutine("Shooting1");
		}
		if (disparando == 2)
		{
			StartCoroutine("Shooting2");
		}
		/*if (change == 1)
		{
			StartCoroutine("Change");
		}*/
	}
	/*
	public void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player" && disparando == 1)
		{
			//print("Hola");
			StartCoroutine("Shooting");
		}
	}

	public void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			StopCoroutine("Shooting");
			disparando = 1;
		}
	}
	*/
	
	public IEnumerator Shooting1()
	{
		disparando = 0;
		GameObject clone = Instantiate(weapon, gunEnd.position, gunEnd.rotation);
		clone.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		disparando = 2;
	}
	public IEnumerator Shooting2()
	{
		disparando = 0;
		GameObject clone2 = Instantiate(weapon2, gunEnd2.position, gunEnd2.rotation);
		clone2.SetActive(true);
		GameObject clone3 = Instantiate(weapon3, gunEnd3.position, gunEnd3.rotation);
		clone3.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		disparando = 1;
	}
}
