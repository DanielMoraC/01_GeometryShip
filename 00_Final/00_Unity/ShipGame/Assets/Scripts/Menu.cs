using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public GameObject Buttons;
    Animator m_Animator;   
    public int map = 0;
    static public int Next = 0;
    // Use this for initialization
    void Start () {       
        m_Animator = Buttons.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		//to know which is the following map
		map = PlayerPrefs.GetInt("CurrentMap");
    }

	//Menu animations
    public void ToControls(){
        m_Animator.SetBool("Controls", true);
    }
    public void BackToMenu(){
        m_Animator.SetBool("Controls", false);
    }
    public void ToPlay(){
        m_Animator.SetBool("Play", true);
    }
    public void BackToMenu2(){
        m_Animator.SetBool("Play", false);
    }

	//Restart the game
    public void Remove()
    {
        PlayerPrefs.DeleteAll();
    }

	//Go to map 1
    public void Map1()
    {
        SceneManager.LoadScene("Map1");
    }

	//Go to menu
    public void ToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

	//Exit the application 
    public void Exit()
    {
        Application.Quit();
    }

	//Start the wave map
	public void Waves()
	{
		SceneManager.LoadScene("WaveMap");
	}

	//Start the normal game in wich map you should
    public void NextMap()
    {
        if (map == 0 && Next == 1)
        {
            SceneManager.LoadScene("Map1");
            //Time.timeScale = 0;
        }
        if (map == 1 && Next == 1)
        {
            SceneManager.LoadScene("Map2");
            //Time.timeScale = 0;
        }
        if (map == 2 && Next == 1)
        {
            SceneManager.LoadScene("Map3");
            //Time.timeScale = 0;
        }
        if (map == 3 && Next == 1)
        {
            SceneManager.LoadScene("Map4");
            //Time.timeScale = 0;
        }
		if (map == 4 && Next == 1)
		{
			SceneManager.LoadScene("Boss");
			//Time.timeScale = 0;
		}

	}

	//Play the map
    public void Play()
    {
        if (map == 0)
        {
            SceneManager.LoadScene("Map1");
            //Time.timeScale = 0;
        }
        if (map == 1)
        {
            SceneManager.LoadScene("Map2");
            //Time.timeScale = 0;
        }
        if (map == 2)
        {
            SceneManager.LoadScene("Map3");
            //Time.timeScale = 0;
        }
        if (map == 3)
        {
            SceneManager.LoadScene("Map4");
            //Time.timeScale = 0;
        }
    }

	//If the player win go to menu and delte the progress
    public void Win()
    {
        SceneManager.LoadScene("Menu");
        PlayerPrefs.DeleteAll();
    }
}
