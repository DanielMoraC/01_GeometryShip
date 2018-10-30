using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkills : MonoBehaviour {

	public bool Skill1;
	public bool Skill2;
	public GameObject PlayerIcon1;
	public GameObject PlayerIcon2;
	public GameObject IconSprite1;
	public GameObject IconSprite2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
/* 
	private void OnCollisionEnter2D(Collision2D collision){
		if (Skill1)
        {
            if (collision.gameObject.tag == "Player")
            {
				StartCoroutine("NoDamage");
				gameObject.SetActive(false);
            }
        }
		if (Skill2)
        {
            if (collision.gameObject.tag == "Player")
            {
				StartCoroutine("Double");
                gameObject.SetActive(false);		
            }
        }
	}*/
	private void OnTriggerEnter2D(Collider2D other) {
		if (Skill1)
        {
            if (other.gameObject.tag == "Player")
            {
				StartCoroutine("NoDamage");
				IconSprite1.SetActive(false);
            }
        }
		if (Skill2)
        {
            if (other.gameObject.tag == "Player")
            {
				StartCoroutine("Double");
                IconSprite2.SetActive(false);		
            }
        }
	}

	public IEnumerator NoDamage(){
		PlayerIcon1.SetActive(true);
		Health.Damaged = false;
		yield return new WaitForSeconds(3f);
		Health.Damaged = true;
		PlayerIcon1.SetActive(false);
		Destroy(this.gameObject);
	}
	public IEnumerator Double(){
		PlayerIcon2.SetActive(true);
		Weapon.DoubleShoot = true;
		yield return new WaitForSeconds(3f);
		Weapon.DoubleShoot = false;
		PlayerIcon2.SetActive(false);
		Destroy(this.gameObject);
	}
}
