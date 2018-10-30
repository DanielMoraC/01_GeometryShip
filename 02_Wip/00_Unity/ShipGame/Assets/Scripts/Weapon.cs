using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject Launcher;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(bulletPrefab, Launcher.transform.position, Quaternion.identity) as GameObject;
            clone.SetActive(true);
        }
	}
}
