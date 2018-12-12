using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public int health = 3;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart4;
    public GameObject heart5;
    public GameObject heart6;
    public GameObject heart0;
    public GameObject heart01;
    public GameObject heart02;

	static public bool Damaged = true;

	public int Lifes = 0;

    Renderer rend;

    public int level;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();

        //Define the amount of life

        level = PlayerPrefs.GetInt("Life1");

        if (level == 1)
        {
            Lifes = PlayerPrefs.GetInt("PlayerLife");
        }

        if (Lifes == 1)
        {
            health = 4;
        }
        if (Lifes == 2)
        {
            health = 5;
        }
        if (Lifes == 3)
        {
            health = 6;
        }
        if (Lifes == 4)
        {
            health = 7;
        }
        if (Lifes == 5)
        {
            health = 8;
        }

		//show the hearts that must be according to health

		if (health == 4)
        {
            heart4.SetActive(true);
            heart0.SetActive(true);
        }
        if (health == 5)
        {
            heart4.SetActive(true);
            heart5.SetActive(true);
            heart01.SetActive(true);
        }
        if (health == 6)
        {
            heart4.SetActive(true);
            heart5.SetActive(true);
            heart6.SetActive(true);
            heart02.SetActive(true);
        }
    }
	
	//Die
	void Update () {
        if (health == 0)
        {
            Die();
        }
	}
    
    //Take damage from enemies

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Damaged){
        
        #region Square
        if (collision.gameObject.tag == "Square")
        {
            if (health == 6)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 5)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else
            if (health == 4)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health==3)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 2)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 1)
            {
                Destroy(collision.gameObject);
                health--;
                StartCoroutine("Hit");
            }
        }
        #endregion Square

        #region Pentagon
        if (collision.gameObject.tag == "Pentagon")
        {
            if (health == 6)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 5)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else
            if (health == 4)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 3)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 2)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 1)
            {
                Destroy(collision.gameObject);
                health--;
                StartCoroutine("Hit");
            }
        }
        #endregion Pentagon

        #region Hexagon
        if (collision.gameObject.tag == "Hexagon")
        {
            if (health == 6)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 5)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else
            if (health == 4)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 3)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 2)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 1)
            {
                Destroy(collision.gameObject);
                health--;
                StartCoroutine("Hit");
            }
        }
        #endregion Hexagon

        #region Octagon
        if (collision.gameObject.tag == "Octagon")
        {
            if (health == 6)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 5)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else
            if (health == 4)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 3)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 2)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 1)
            {
                Destroy(collision.gameObject);
                health--;
                StartCoroutine("Hit");
            }
        }
        #endregion Octagon

        #region Dodecagon
        if (collision.gameObject.tag == "Dodecagon")
        {
            if (health == 6)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 5)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else
            if (health == 4)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 3)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 2)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 1)
            {
                Destroy(collision.gameObject);
                health--;
                StartCoroutine("Hit");
            }
        }
        #endregion Dodecagon

        #region Double
        if (collision.gameObject.tag == "Double")
        {
            if (health == 6)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 5)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 4)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 3)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 2)
            {
                Destroy(collision.gameObject);
                health--;
                HitDamage();
                StartCoroutine("Hit");
            }
            else if (health == 1)
            {
                Destroy(collision.gameObject);
                health--;
                StartCoroutine("Hit");
            }
        }
			#endregion Double

		#region Shot
		if (collision.gameObject.tag == "Shot")
		{
			if (health == 6)
			{
				Destroy(collision.gameObject);
				health--;
				HitDamage();
				StartCoroutine("Hit");
			}
			else if (health == 5)
			{
				Destroy(collision.gameObject);
				health--;
				HitDamage();
				StartCoroutine("Hit");
			}
			else if (health == 4)
			{
				Destroy(collision.gameObject);
				health--;
				HitDamage();
				StartCoroutine("Hit");
			}
			else if (health == 3)
			{
				Destroy(collision.gameObject);
				health--;
				HitDamage();
				StartCoroutine("Hit");
			}
			else if (health == 2)
			{
				Destroy(collision.gameObject);
				health--;
				HitDamage();
				StartCoroutine("Hit");
			}
			else if (health == 1)
			{
				Destroy(collision.gameObject);
				health--;
				StartCoroutine("Hit");
			}
		}
			#endregion Shot

		#region ShotBullet
			if (collision.gameObject.tag == "ShotBullet")
			{
				if (health == 6)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 5)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 4)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
			#endregion ShotBullet

		#region BossBullet
			if (collision.gameObject.tag == "BossBullet")
			{
				if (health == 6)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 5)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 4)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 3)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 2)
				{
					Destroy(collision.gameObject);
					health--;
					HitDamage();
					StartCoroutine("Hit");
				}
				else if (health == 1)
				{
					Destroy(collision.gameObject);
					health--;
					StartCoroutine("Hit");
				}
			}
		#endregion BossBullet
		}
	}

    public virtual void Die()
    {
        SceneManager.LoadScene("Defeat");
    }

    //deactivate the hearts when the player get damages

    public virtual void HitDamage()
    {
        if (health == 5)
        {
            heart6.SetActive(false);
        }
        if (health == 4)
        {
            heart5.SetActive(false);
        }
        if (health == 3)
        {
            heart4.SetActive(false);
        }
        else if (health == 2)
        {
            heart3.SetActive(false);
        }else if (health == 1)
        {
            heart2.SetActive(false);
        }
    }

    //When you get hit the player sprite turn red for a half a second

    IEnumerator Hit()
    {
        rend.material.color = Color.red;
        yield return new WaitForSeconds(0.5f);
        rend.material.color = Color.white;
    }
}
