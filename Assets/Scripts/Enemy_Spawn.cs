using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{

//Gets the enemyprefab for the spawnpoint

    public GameObject enemyPrefab;
    private GameObject enemy;

	//an update function that will position the enemy at the spawnpoint allowing them to move in a random direction
    void Update()
    {
        if (enemy == null)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 1, 0);

            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);
        }
    }
}