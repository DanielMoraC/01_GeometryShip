﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefineVariables : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("PlayerDamage", 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
