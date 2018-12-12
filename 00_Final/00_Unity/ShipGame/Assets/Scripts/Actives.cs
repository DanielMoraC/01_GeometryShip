using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actives : MonoBehaviour {

	public GameObject Player;
	public GameObject LauncherGranade;
	public GameObject LauncherBlast;
	public bool ActiveSkill1;
	public bool ActiveSkill2;
	public bool ActiveSkill3;
	public GameObject Skill1;
	public GameObject SkillIcon1;
	public GameObject Skill2;
	public GameObject SkillIcon2;
	public GameObject Skill3;
	public GameObject SkillIcon3;
	public GameObject SkillIconCanvas3;
	public GameObject SkillIconCanvas1;
	public GameObject SkillIconCanvas2;

	public int Skill = 0;

	// Use this for initialization
	void Start () {
		Skill = PlayerPrefs.GetInt("ActiveNumber");		
	}
	
	// Update is called once per frame
	void Update () {
		//Image On the canvas
		if(Skill == 1){
			SkillIconCanvas1.SetActive(true);
		}
		if(Skill == 2){
			SkillIconCanvas2.SetActive(true);
		}
		if(Skill == 3){
			SkillIconCanvas3.SetActive(true);
		}
		//Granade
		if(Skill == 1 && ActiveSkill1 && Input.GetKeyDown(KeyCode.Space)){
			StartCoroutine("Granade");
			Skill = 0;
		}
		//Enegy Field
		if(Skill == 2 && ActiveSkill2 && Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine("EnergyField");
            Skill = 0;
        }
		//Blast
		if(Skill == 3 && ActiveSkill3 && Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine("Blast");
            Skill = 0;
        }
	}

	//Launch the grande
	public IEnumerator Granade(){
		gameObject.transform.position = LauncherGranade.transform.position;		
		SkillIcon1.SetActive(true);
		yield return new WaitForSeconds(2f);
		Skill1.SetActive(true);
	}

	//Active the energy field
    public IEnumerator EnergyField()
    {
        gameObject.transform.position = Player.transform.position;        
        SkillIcon2.SetActive(true);        
        Skill2.SetActive(true);
        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }

	//Active the blast
    public IEnumerator Blast()
    {
        Skill3.transform.position = LauncherBlast.transform.position;
        Skill3.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Destroy(this.gameObject);
    }
}
