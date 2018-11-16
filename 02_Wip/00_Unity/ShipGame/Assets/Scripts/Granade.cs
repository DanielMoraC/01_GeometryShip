using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour {

	public GameObject Empty;
	public GameObject Particle;
	public GameObject Icon;
	public bool Started = true;

	// Use this for initialization
	void Start () {
		StartCoroutine("Explosion");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionStay2D(Collision2D other) {
		if(Started){		
			if (other.gameObject.tag == "Square")
        	{
        	    EnemySpawner.MaxEnemies--;
        	    Destroy(other.gameObject);
        	}
			if (other.gameObject.tag == "Pentagon")
        	{
            	Destroy(other.gameObject);
            	EnemySpawner.MaxEnemies--;
        	}
			if (other.gameObject.tag == "Hexagon")
        	{
        	    EnemySpawner.MaxEnemies--;
        	    Destroy(other.gameObject);
        	}
			if (other.gameObject.tag == "Octagon")
        	{
        	    Destroy(other.gameObject);
        	    EnemySpawner.MaxEnemies--;
        	}
			if (other.gameObject.tag == "Dodecagon")
        	{
        	    EnemySpawner.MaxEnemies--;
        	    Destroy(other.gameObject);
        	}
			if (other.gameObject.tag == "Double")
        	{
            	EnemySpawner.MaxEnemies--;
            	Destroy(other.gameObject);
        	}
			if (other.gameObject.tag == "Shot")
        	{
           		EnemySpawner.MaxEnemies--;
         		Destroy(other.gameObject);
        	}
		}
	}
	public IEnumerator Explosion(){		
		Icon.SetActive(false);
		Particle.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		Started = false;	
		yield return new WaitForSeconds(2f);
		Destroy(Empty);		
	}
}
