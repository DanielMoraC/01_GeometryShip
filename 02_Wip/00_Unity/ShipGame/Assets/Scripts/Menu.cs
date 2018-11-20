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
        map = PlayerPrefs.GetInt("CurrentMap");
    }
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
    public void Remove()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Map1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void ToMenu()
    {
        //Time.timeScale = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

    public void Exit()
    {
        Application.Quit();
    }

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

    public void Win()
    {
        SceneManager.LoadScene("Menu");
        PlayerPrefs.DeleteAll();
    }
}
