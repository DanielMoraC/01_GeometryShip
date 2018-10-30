using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position = new Vector3(player.gameObject.transform.position.x, player.transform.position.y, -3.221469f);
    }
}
