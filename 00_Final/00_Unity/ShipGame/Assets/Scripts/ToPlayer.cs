using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToPlayer : MonoBehaviour {

    public GameObject Player;
    private float Speed;

	// Use this for initialization
	void Start () {
        
    }
	
	//Make the enemies go for the player
	void Update () {
		Vector3 dir = Player.transform.position - transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle -90, Vector3.forward);

		Speed = 1.7f * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Speed);
    }
}
