using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public GameObject bulletPrefab2;
    public GameObject bulletPrefab3;
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
                GameObject clone1 = Instantiate(bulletPrefab, Launcher.transform.position, Quaternion.identity) as GameObject;
                clone1.SetActive(true);
            }
        }
        if(DoubleShoot){
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GameObject clone2 = Instantiate(bulletPrefab2, Launcher2.transform.position, Quaternion.identity) as GameObject;
                clone2.SetActive(true);
                GameObject clone3 = Instantiate(bulletPrefab3, Launcher3.transform.position, Quaternion.identity) as GameObject;
                clone3.SetActive(true);
            }
        }
        
	}
}
