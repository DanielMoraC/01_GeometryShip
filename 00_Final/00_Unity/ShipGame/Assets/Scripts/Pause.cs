using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject menu;

    public bool opened = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && opened)
        {           
            opened = false;
            menu.SetActive(false);
            PauseGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !opened)
        {
            opened = true;
            menu.SetActive(true);
            StartGame();
        }
    }

    public void PlayAgain()
    {
        menu.SetActive(false);
        opened = false;
        PauseGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 1;
    }

    public void StartGame()
    {
        Time.timeScale = 0;
    }
}
