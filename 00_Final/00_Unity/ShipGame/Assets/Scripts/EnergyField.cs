using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyField : MonoBehaviour {

    public GameObject Player;
    public GameObject Empty;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Move with the player
        Empty.transform.position = Player.transform.position;
	}

	//Kill the enemies when they touch the energy field
	private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Square")
        {
            EnemySpawner.MaxEnemies--;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Pentagon")
        {
            EnemySpawner.MaxEnemies--;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Hexagon")
        {
            EnemySpawner.MaxEnemies--;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Octagon")
        {
            EnemySpawner.MaxEnemies--;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Dodecagon")
        {
            EnemySpawner.MaxEnemies--;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Double")
        {
            EnemySpawner.MaxEnemies--;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Shot")
        {
            EnemySpawner.MaxEnemies--;
            Destroy(collision.gameObject);
        }
		if (collision.gameObject.tag == "BossBullet")
		{
			Destroy(collision.gameObject);
		}

	}
}
