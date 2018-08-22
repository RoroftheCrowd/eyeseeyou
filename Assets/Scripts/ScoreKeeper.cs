using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{

    //Setting the score to 0 at the start of the game
	int score = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementScore(int amount)
    {
        score += amount;
        //displayScore();
        //AudioSource source = GetComponent<AudioSource>();
        //source.Play();
    }

    //A void showing the player their score when the game is over 
	void displayScore()
    {
        print("Your score is: " + score);
    }

    //a public integer returning the score of the player
	public int getScore()
    {
        return score;
    }
}
