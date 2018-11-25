﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossHP : MonoBehaviour {

	public Image HPBar;
	public float hitpoint = 100;
	public float maxhitpoint = 100;

	static public float damage = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateHealthbar();
	}

	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Bullet")
		{
			TakeDamage();
		}
	}

	private void TakeDamage()
	{
		hitpoint -= damage;
		if (hitpoint <= 0)
		{
			hitpoint = 0;
			//Debug.Log("Death");
			SceneManager.LoadScene("Win");
		}
		UpdateHealthbar();
	}

	private void UpdateHealthbar()
	{
		float ratio = hitpoint / maxhitpoint;
		HPBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
	}
}