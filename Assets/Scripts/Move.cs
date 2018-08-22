using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

	//A simple script allowing the player to move in a horizontal and vertical direction
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		//Allows the player to control the character with the WASD keys.
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
