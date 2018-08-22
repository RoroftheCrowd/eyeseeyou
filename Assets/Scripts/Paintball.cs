using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintball : MonoBehaviour
{
    //A public method setting the paintball speed to 20 allowing for fast movement and the damage it will inflict on the player
	public float speed = 20.0f;
    public int damage = 1;

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    //A void making sure that the paintball hits the player giving them damage and updating their health in the playerinfo script
	void OnTriggerEnter(Collider other)
    {
        PlayerInfo player = other.GetComponent<PlayerInfo>();
        if (player != null)
        {
            player.Hurt(damage);
        }
		//if the player reaches 0 on the health bar they will die
        Destroy(this.gameObject);

    }
}