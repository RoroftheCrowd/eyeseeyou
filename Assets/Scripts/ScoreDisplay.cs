using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
	//References for the ScoreKeeper,Player_Shooter and LevelManager scripts 
    ScoreKeeper sk;
    Player_Shooter ps;
    LevelManager lm;
	
	//Public instances for the score,ammo and time text that will be displayed on the level
    public Text scoreText;
    public Text ammoText;
    public Text timeText;

    // Use this for initialization
    void Start()
    {
        sk = FindObjectOfType<ScoreKeeper>();
        ps = FindObjectOfType<Player_Shooter>();
        lm = FindObjectOfType<LevelManager>();
        //scoreText = GetComponent<Text>();
        //ammoText = GetComponent("Ammo") as Text;
        //timeText = GetComponent("Time") as Text;
    }

    // Update is called once per frame
   void Update()
    {
    //Text refeneces that will show the score,ammo and time the player has used, earned and remaining
		scoreText.text = "Score: " + sk.getScore();
        ammoText.text = "Ammo: " + ps.getAmmo();
        timeText.text = "Time: " + lm.timeRemaining;
    }
}
