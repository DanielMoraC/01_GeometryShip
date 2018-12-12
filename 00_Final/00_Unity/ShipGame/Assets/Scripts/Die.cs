using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour {

	//When the player dies on wave map goes to a scene 
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("Defeat");
		}
	}
}
