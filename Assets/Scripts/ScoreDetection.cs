using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDetection : MonoBehaviour
{
    //The player will receive 1 point for every enemy that they hit
	public int scorePerHit = 1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
	
	//A collision that will be used to find the score and calculate how many points the player will get per hit
    void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementScore(scorePerHit);
    }
}
