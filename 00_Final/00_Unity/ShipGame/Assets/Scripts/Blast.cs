using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour {

    public GameObject Player;
    public GameObject PlayerRotation;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Set the position and rotation with player
        gameObject.transform.position = Player.transform.position;
        gameObject.transform.rotation = PlayerRotation.transform.rotation;
	}

	//Kill the enemies when they touch the blast
	private void OnTriggerEnter2D(Collider2D collision)
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
