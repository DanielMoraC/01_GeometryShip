using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPlayer : MonoBehaviour {

    public GameObject Player;

    private float Speed;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        Speed = 1.7f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed);
    }
}
