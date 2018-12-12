using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WaveEnemySpawner : MonoBehaviour {

	static public int Wave = 0;

	public TMP_Text WaveNumber;

	public bool Spawning = true;
	public GameObject FinalEffect;

	static public int EnemiesNumber;
	public GameObject[] Enemies1;
	public GameObject[] Enemies2;
	public GameObject[] Enemies3;
	public GameObject[] Enemies4;

	static public int Damage;

	// Use this for initialization
	void Start () {
		Wave = 0;

		EnemiesNumber = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Show the wave the player is in
		WaveNumber.text = Wave.ToString();

		//Set Damage

		if (Wave == 0)
		{
			Damage = 1;
		}
		if (Wave == 1)
		{
			Damage = 2;
		}
		if (Wave >= 2)
		{
			Damage = 3;
		}

		//Spawn the enemies

		if (Wave == 0)
		{
			if (EnemiesNumber > 0 && Spawning)
			{
				StartCoroutine("Spawn1");
			}
			if (EnemiesNumber == 0)
			{
				StartCoroutine("WaveKilled");
				Wave++;
				Destroy(GameObject.FindWithTag("Square"));
				Destroy(GameObject.FindWithTag("Pentagon"));
				SetNumber();
			}
		}

		if (Wave == 1)
		{
			if (EnemiesNumber > 0 && Spawning)
			{
				StartCoroutine("Spawn2");
			}
			if (EnemiesNumber == 0)
			{
				StartCoroutine("WaveKilled");
				Wave++;
				Destroy(GameObject.FindWithTag("Octagon"));
				Destroy(GameObject.FindWithTag("Hexagon"));
				SetNumber();
			}
		}

		if (Wave == 2)
		{
			if (EnemiesNumber > 0 && Spawning)
			{
				StartCoroutine("Spawn3");
			}
			if (EnemiesNumber == 0)
			{
				StartCoroutine("WaveKilled");
				Wave++;
				Destroy(GameObject.FindWithTag("Octagon"));
				Destroy(GameObject.FindWithTag("Dodecagon"));
				SetNumber();
			}
		}

		if (Wave >= 3)
		{
			if (EnemiesNumber > 0 && Spawning)
			{
				StartCoroutine("Spawn4");
			}
			if (EnemiesNumber == 0)
			{
				StartCoroutine("WaveKilled");
				Wave++;
				Destroy(GameObject.FindWithTag("Double"));
				Destroy(GameObject.FindWithTag("Square"));
				Destroy(GameObject.FindWithTag("Shot"));
				SetNumber();
			}
		}
	}

	//Set the number of enemies on each wave

	public void SetNumber()
	{
		if (Wave == 1)
		{
			EnemiesNumber = 10;
		}

		if (Wave >= 2)
		{
			EnemiesNumber = 15;
		}
	}

	//Effect of wave passed

	IEnumerator WaveKilled()
	{
		FinalEffect.SetActive(true);
		yield return new WaitForSeconds(0.15f);
		FinalEffect.SetActive(false);
	}

	//Set the position for the spawn and the enemie random
	IEnumerator Spawn1()
	{
		Spawning = false;

		Vector2 spawnPos = PlayerController.Position; 
		spawnPos += Random.insideUnitCircle * 2; 

		int EnemiesIndex = Random.Range(0, Enemies1.Length);
		GameObject clone = Instantiate(Enemies1[EnemiesIndex], spawnPos, Quaternion.identity);
		clone.SetActive(true);
		yield return new WaitForSeconds(1f);
		Spawning = true;
	}

	//Set the position for the spawn and the enemie random
	IEnumerator Spawn2()
	{
		Spawning = false;

		Vector2 spawnPos = PlayerController.Position; 
		spawnPos += Random.insideUnitCircle * 2; 

		int EnemiesIndex = Random.Range(0, Enemies2.Length);
		GameObject clone = Instantiate(Enemies2[EnemiesIndex], spawnPos, Quaternion.identity);
		clone.SetActive(true);
		yield return new WaitForSeconds(1f);
		Spawning = true;
	}

	//Set the position for the spawn and the enemie random
	IEnumerator Spawn3()
	{
		Spawning = false;

		Vector2 spawnPos = PlayerController.Position;
		spawnPos += Random.insideUnitCircle * 2;

		int EnemiesIndex = Random.Range(0, Enemies3.Length);
		GameObject clone = Instantiate(Enemies3[EnemiesIndex], spawnPos, Quaternion.identity);
		clone.SetActive(true);
		yield return new WaitForSeconds(1f);
		Spawning = true;
	}

	//Set the position for the spawn and the enemie random
	IEnumerator Spawn4()
	{
		Spawning = false;

		Vector2 spawnPos = PlayerController.Position;
		spawnPos += Random.insideUnitCircle * 2;

		int EnemiesIndex = Random.Range(0, Enemies4.Length);
		GameObject clone = Instantiate(Enemies4[EnemiesIndex], spawnPos, Quaternion.identity);
		clone.SetActive(true);
		yield return new WaitForSeconds(1f);
		Spawning = true;
	}
}
