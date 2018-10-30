using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject Launcher;
    public GameObject Launcher2;
    public GameObject Launcher3;

    static public bool DoubleShoot = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!DoubleShoot){
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject clone = Instantiate(bulletPrefab, Launcher.transform.position, Quaternion.identity) as GameObject;
                clone.SetActive(true);
            }
        }
        if(DoubleShoot){
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject clone = Instantiate(bulletPrefab, Launcher2.transform.position, Quaternion.identity) as GameObject;
                clone.SetActive(true);
                GameObject clone1 = Instantiate(bulletPrefab, Launcher3.transform.position, Quaternion.identity) as GameObject;
                clone.SetActive(true);
            }
        }
        
	}
}
