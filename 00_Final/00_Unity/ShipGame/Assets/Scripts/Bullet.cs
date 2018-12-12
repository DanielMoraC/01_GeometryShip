using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Vector3 direction;
    public GameObject Launcher1;
    public GameObject Launcher2;
    public GameObject Launcher3;
    public bool bullet1;
    public bool bullet2;
    public bool bullet3;


    // Use this for initialization
    void Start () {

        //Speed of the bullets
        float vX = 4f * Time.deltaTime;

        //Direction and Spawn of the bullets
        if(bullet1){
        transform.Translate(Launcher1.transform.up * vX);
        direction = Launcher1.transform.up;
        }
        if(bullet2){
        transform.Translate(Launcher2.transform.up * vX);
        direction = Launcher2.transform.up;
        }
        if(bullet3){
        transform.Translate(Launcher3.transform.up * vX);
        direction = Launcher3.transform.up;
        }
    }
	
	// Update is called once per frame
	void Update () {

        //Speed and direction of the bullet
        float vX = 4f * Time.deltaTime;
        transform.Translate(direction * vX);
    }

    //Destoy de bullet if it hits a wall
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject, 0);
        }
    }
}
