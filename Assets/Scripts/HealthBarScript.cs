using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {
    //A reference to the healthbar image
	Image healthBar;
    
    PlayerInfo info;
    // Use this for initialization
    void Start () {
        //A start method that looks for the health bar above the screen
		healthBar = GetComponent<Image>();
       
        info = (PlayerInfo) FindObjectOfType(typeof(PlayerInfo));
	}

	
	// an update method used to update the health bar whenever the player takes damage
	void Update () {
        healthBar.fillAmount = info.getHealthRatio();
	}
}
