using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject menu;

    public bool opened = false;

	// Use this for initialization
	void Start () {
		
	}
	
	//Update is called once per frame
	void Update () {

		//If you press escape the game is paused and the menu appears or resume
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

	//If the player press the pause button
    public void PlayAgain()
    {
        menu.SetActive(false);
        opened = false;
        PauseGame();
    }

	//Pause the game
    public void PauseGame()
    {
        Time.timeScale = 1;
    }

	//Resume
    public void StartGame()
    {
        Time.timeScale = 0;
    }
}
