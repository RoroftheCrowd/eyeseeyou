using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    //a private method that will be used to keep an integer of the players health
    private int _health;

    //The method that gives the player their health 
    public float maxHealth = 100;
    void Start()

    //The max health that the player will have when the game starts
    {
        _health = 100;
    }

    //A public that will take health away from the player whenever they're hit
    public void Hurt(int damage)
    {
        _health -= damage;

    }


    //Calculates the hit/full health ratio of the health bar
    public float getHealthRatio()
    {
        float HealthRatio = _health / maxHealth;
        return HealthRatio;
    }
    // If the player has run out of health...
        
}