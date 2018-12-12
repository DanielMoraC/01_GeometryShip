using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineVariables : MonoBehaviour {

	//Set the damage of the player at 1 on the first map
	void Start () {
        PlayerPrefs.SetInt("PlayerDamage", 1);
    }
}
