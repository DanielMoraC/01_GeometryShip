﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour {

    public int S1 = 0;
    public int S2 = 0;
    public int S3 = 0;

    public int Lvl = 0;

    // Use this for initialization
    void Start () {
		S1 = PlayerPrefs.GetInt("Skill1");
        S2 = PlayerPrefs.GetInt("Skill2");
        S3 = PlayerPrefs.GetInt("Skill3");
        Lvl = PlayerPrefs.GetInt("Lvl");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Skill1()
    {
        if (Lvl == 1)
        {       
            if (S1 == 0)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill1", 1);
                PlayerPrefs.SetInt("Leveled1", 1);
                PlayerPrefs.SetFloat("PlayerSpeed", 2.5f);
                PlayerPrefs.SetInt("Lvl" , 0);
            }
            if (S1 == 1)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill1", 2);
                PlayerPrefs.SetInt("Leveled1", 1);
                PlayerPrefs.SetFloat("PlayerSpeed", 3f);
                PlayerPrefs.SetInt("Lvl", 0);
            }
            if (S1 == 2)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill1", 3);
                PlayerPrefs.SetInt("Leveled1", 1);
                PlayerPrefs.SetFloat("PlayerSpeed", 4f);
                PlayerPrefs.SetInt("Lvl", 0);
            }
        }
    }
    public void Skill2()
    {
        if (Lvl == 1)
        {
            if (S2 == 0)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill2", 1);
                PlayerPrefs.SetInt("Damage1", 1);
                PlayerPrefs.SetInt("PlayerDamage", 2);
                PlayerPrefs.SetInt("Lvl", 0);
            }
            if (S2 == 1)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill2", 2);
                PlayerPrefs.SetInt("Damage1", 1);
                PlayerPrefs.SetInt("PlayerDamage", 3);
                PlayerPrefs.SetInt("Lvl", 0);
            }
            if (S2 == 2)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill2", 3);
                PlayerPrefs.SetInt("Damage1", 1);
                PlayerPrefs.SetInt("PlayerDamage", 4);
                PlayerPrefs.SetInt("Lvl", 0);
            }
        }
    }

    public void Skill3()
    {
        if (Lvl == 1)
        {
            if (S3 == 0)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill3", 1);
                PlayerPrefs.SetInt("Life1", 1);
                PlayerPrefs.SetInt("PlayerLife", 1);
                PlayerPrefs.SetInt("Lvl", 0);
            }
            if (S3 == 1)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill3", 2);
                PlayerPrefs.SetInt("Life1", 1);
                PlayerPrefs.SetInt("PlayerLife", 2);
                PlayerPrefs.SetInt("Lvl", 0);
            }
            if (S3 == 2)
            {
                Menu.Next = 1;
                PlayerPrefs.SetInt("Skill3", 3);
                PlayerPrefs.SetInt("Life1", 1);
                PlayerPrefs.SetInt("PlayerLife", 3);
                PlayerPrefs.SetInt("Lvl", 0);
            }
        }
    }
}
