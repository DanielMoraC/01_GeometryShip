using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Vector3 direction;
    public GameObject Launcher;


    // Use this for initialization
    void Start () {
        float vX = 4f * Time.deltaTime;
        transform.Translate(Launcher.transform.up * vX);
        direction = Launcher.transform.up;
    }
	
	// Update is called once per frame
	void Update () {
        float vX = 4f * Time.deltaTime;
        transform.Translate(direction * vX);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject, 0);
        }
    }
}
