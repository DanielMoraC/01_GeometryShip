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
    public bool EnemyDouble = false;
    private int LifeDouble = 4;
    public bool EnemyShot = false;
    private int LifeShot = 3;

    public int Damage = 1;
    public GameObject Icon1;
    public GameObject Icon2;
    
    Vector2 mousePos = Vector2.zero;
    public int level;

    public GameObject Square1;
    public GameObject Father;

    // Use this for initialization
    void Start () {

        //Define the damage

        level = PlayerPrefs.GetInt("Damage1");

        if (level == 1)
        {
            Damage = PlayerPrefs.GetInt("PlayerDamage");
        }
    }
    
    // Update is called once per frame
    void Update () {

        //Mouse Position for spawn

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos;

        //Spawn skills

        if(SkillsCount.Killeds == 4 && SkillsCount.SkillsSpawned == 0){
            SkillsCount.SkillsSpawned++;              
            GameObject clone = Instantiate(Icon1, lookDir, Quaternion.identity);      
            clone.SetActive(true);
        }
        if(SkillsCount.Killeds == 8 && SkillsCount.SkillsSpawned == 1){
            SkillsCount.SkillsSpawned++;
            GameObject clone = Instantiate(Icon2, lookDir, Quaternion.identity);        
            clone.SetActive(true);
        }

        //When enemies die

        if (LifeSquare <= 0)
        {
            SkillsCount.Killeds++;
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifePentagon <= 0)
        {
			SkillsCount.Killeds++;
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifeOctagon <= 0)
        {
			SkillsCount.Killeds++;
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifeHexagon <= 0)
        {
			SkillsCount.Killeds++;
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifeDodecagon <= 0)
        {
			SkillsCount.Killeds++;
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
        if (LifeDouble <= 0)
        {
			GameObject clone1 = Instantiate(Square1, Father.transform.position, Quaternion.identity) as GameObject;
			clone1.SetActive(true);
			SkillsCount.Killeds++;
            EnemySpawner.MaxEnemies--;
            Destroy(Father);
        }
        if (LifeShot <= 0)
        {
			SkillsCount.Killeds++;
            EnemySpawner.MaxEnemies--;
            Destroy(this.gameObject);
        }
    }

    //When the bullet hit an enemy it lose health and destroy the bullet

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
        if (EnemyDouble)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                LifeDouble -= Damage;
                Destroy(collision.gameObject);
            }
        }
        if (EnemyShot)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                LifeShot -= Damage;
                Destroy(collision.gameObject);
            }
        }
    }
}
