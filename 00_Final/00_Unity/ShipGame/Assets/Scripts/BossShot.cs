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
		//The two types of shooting of the boss
		if (disparando == 1)
		{
			StartCoroutine("Shooting1");
		}
		if (disparando == 2)
		{
			StartCoroutine("Shooting2");
		}
	}

	//Boss shooting straight
	public IEnumerator Shooting1()
	{
		disparando = 0;
		GameObject clone = Instantiate(weapon, gunEnd.position, gunEnd.rotation);
		clone.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		disparando = 2;
	}

	//boss shooting sideways
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
