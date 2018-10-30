using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {

    public bool EnemySquare = false;
    private int LifeSquare = 1;
    public bool EnemyPentagon = false;
    private int LifePentagon = 1;
    public bool EnemyHexagon = false;
    private int LifeHexagon = 2;
    public bool EnemyOctagon = false;
    private int LifeOctagon = 2;
    public bool EnemyDodecagon = false;
    private int LifeDodecagon = 3;

    public int Damage = 1;

    public int level;

    // Use this for initialization
    void Start () {
        level = PlayerPrefs.GetInt("Damage1");

        if (level == 1)
        {
            Damage = PlayerPrefs.GetInt("PlayerDamage");
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (LifeSquare <= 0)
        {
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifePentagon <= 0)
        {
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifeOctagon <= 0)
        {
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifeHexagon <= 0)
        {
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifeDodecagon <= 0)
        {
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (EnemySquare)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                LifeSquare -= Damage;
                Destroy(collision.gameObject);
            }
        }
        if (EnemyPentagon)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                LifePentagon -= Damage;
                Destroy(collision.gameObject);
            }
        }
        if (EnemyOctagon)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                LifeOctagon -= Damage;
                Destroy(collision.gameObject);
            }
        }
        if (EnemyHexagon)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                LifeHexagon -= Damage;
                Destroy(collision.gameObject);
            }
        }
        if (EnemyDodecagon)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                LifeDodecagon -= Damage;
                Destroy(collision.gameObject);
            }
        }
    }
}
