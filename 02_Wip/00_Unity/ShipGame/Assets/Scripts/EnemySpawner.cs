using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour {

    static public int MaxEnemies;
    public TMP_Text EnemiesLeft;

    public int map;

    public bool Spawning = true;

    public GameObject[] Enemies;  

    // Use this for initialization
    void Start () {

        //Define the map and the max enemies

        map = PlayerPrefs.GetInt("CurrentMap");

        if (map == 0)
        {
            MaxEnemies = 10;
        }

        if (map == 1)
        {
            MaxEnemies = 15;
        }

        if (map == 2)
        {
            MaxEnemies = 20;
        }

    }
	
	// Update is called once per frame
	void Update () {   
       
        EnemiesLeft.text = MaxEnemies.ToString();

        //Spawn the enemies

        if (map == 0)
        {
            if (MaxEnemies > 0 && Spawning)
            {
                StartCoroutine("Spawn1");
            }
            if (MaxEnemies == 0)
            {
                PlayerPrefs.SetInt("Lvl", 1);
                PlayerPrefs.SetInt("CurrentMap", 1);
                Destroy(GameObject.FindWithTag("Square"));
                Destroy(GameObject.FindWithTag("Pentagon"));
                SceneManager.LoadScene("LevelUp");
            }
        }
        if (map == 1)
        {
            if (MaxEnemies > 0 && Spawning)
            {
                StartCoroutine("Spawn2");
            }
            if (MaxEnemies == 0)
            {
                PlayerPrefs.SetInt("Lvl", 1);
                PlayerPrefs.SetInt("CurrentMap", 2);
                Destroy(GameObject.FindWithTag("Octagon"));
                Destroy(GameObject.FindWithTag("Hexagon"));
                SceneManager.LoadScene("LevelUp");
            }
        }

        if (map == 2)
        {
            if (MaxEnemies > 0 && Spawning)
            {
                StartCoroutine("Spawn3");
            }
            if (MaxEnemies == 0)
            {
                PlayerPrefs.SetInt("Lvl", 1);
                PlayerPrefs.SetInt("CurrentMap", 3);
                Destroy(GameObject.FindWithTag("Octagon"));
                Destroy(GameObject.FindWithTag("Dodecagon"));
                //SceneManager.LoadScene("LevelUp");
                SceneManager.LoadScene("Win");
            }
        }
    }

    //Set the position for the spawn

    IEnumerator Spawn1()
    {
        Spawning = false;

        //Vector2 spawnPos = transform.position = Random.insideUnitCircle * 2; Opcion 2
        //Vector2 spawnPos = new Vector2 (Random.Range(-1f, 1f), Random.Range(-1f, 1f)); Opcion3
        //Vector2 spawnPos = new Vector2(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f)); Opcion4 pero aparece siempre desde el mismo sitio
        Vector2 spawnPos = PlayerController.Position; //Opcion1
        spawnPos += Random.insideUnitCircle * 2; //Opcion1

        int EnemiesIndex = Random.Range(0, Enemies.Length);
        GameObject clone = Instantiate(Enemies[EnemiesIndex], spawnPos, Quaternion.identity);        
        clone.SetActive(true);
        yield return new WaitForSeconds(1f);
        Spawning = true;
    }

    IEnumerator Spawn2()
    {
        Spawning = false;

        //Vector2 spawnPos = transform.position = Random.insideUnitCircle * 2; Opcion 2
        //Vector2 spawnPos = new Vector2 (Random.Range(-1f, 1f), Random.Range(-1f, 1f)); Opcion3
        //Vector2 spawnPos = new Vector2(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f)); Opcion4 pero aparece siempre desde el mismo sitio
        Vector2 spawnPos = PlayerController.Position; //Opcion1
        spawnPos += Random.insideUnitCircle * 2; //Opcion1

        int EnemiesIndex = Random.Range(0, Enemies.Length);
        GameObject clone = Instantiate(Enemies[EnemiesIndex], spawnPos, Quaternion.identity);
        clone.SetActive(true);
        yield return new WaitForSeconds(1f);
        Spawning = true;
    }

    IEnumerator Spawn3()
    {
        Spawning = false;

        //Vector2 spawnPos = transform.position = Random.insideUnitCircle * 2; Opcion 2
        //Vector2 spawnPos = new Vector2 (Random.Range(-1f, 1f), Random.Range(-1f, 1f)); Opcion3
        //Vector2 spawnPos = new Vector2(Random.Range(0.5f, 1f), Random.Range(0.5f, 1f)); Opcion4 pero aparece siempre desde el mismo sitio
        Vector2 spawnPos = PlayerController.Position; //Opcion1
        spawnPos += Random.insideUnitCircle * 2; //Opcion1

        int EnemiesIndex = Random.Range(0, Enemies.Length);
        GameObject clone = Instantiate(Enemies[EnemiesIndex], spawnPos, Quaternion.identity);
        clone.SetActive(true);
        yield return new WaitForSeconds(1f);
        Spawning = true;
    }

}
