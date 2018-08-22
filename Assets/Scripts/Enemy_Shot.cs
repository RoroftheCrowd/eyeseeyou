using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shot : MonoBehaviour
{
    //When the enemy is shot the player will get ten points for every shot they take
	public int scorePerHit = 10;
    public void GotShot()
    {
       //Halts the enemy movement by summoning the Enemy_Movement script changing them from alive to dead
	   Enemy_Movement behavior = GetComponent<Enemy_Movement>();
        if (behavior != null)
        {
            behavior.SetAlive(false);
        }

        StartCoroutine(Die());
    }

    //A respawn time of 1.5 seconds for the enemy in which case the player can keep shooting them causing them to tilt
	private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject);
		
		//Adds the points to the players score by referencing the scorekeeper script
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementScore(scorePerHit);
    }

}