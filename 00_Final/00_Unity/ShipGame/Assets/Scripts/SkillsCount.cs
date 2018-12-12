using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsCount : MonoBehaviour {

	//To have a count on the kills for the actives that enemies drop
	static public int Killeds = 0;	
	static public int SkillsSpawned = 0;

	//Define the skills
	void Start () {
		Killeds = 0;
		SkillsSpawned = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
