using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    //Setting the movement of the enemy and the range where they can attack the player
	public float speed = 3.0f;
    public float obstacleRange = 5.0f;

   //Setting thier status to alive when the game starts
   private bool _alive;

   //Summons the paintballPrefab for them to use as a weapon against the player
    public GameObject paintballPrefab;
    private GameObject _paintball;

    //When the game starts they're already alive
	void Start()
    {
        _alive = true;
    }

    
	//An update function setting up on how they will navigate in the map
    void Update()
    {
        if (_alive)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            GameObject hitObject = hit.transform.gameObject;
            if (hitObject.GetComponent<PlayerInfo>())
            {
                //an if else statement saying weather or not they will use their paintballPrefab on the player if they are in range of them
				if (_paintball == null)
                {
                    _paintball = Instantiate(paintballPrefab) as GameObject;
                    _paintball.transform.position = transform.TransformPoint(Vector3.forward * 1.5f);
                    _paintball.transform.rotation = transform.rotation;
                }
            }
            
			//if they're hit they will levitate in the air on their side and continue to change angle if they're hit
			else if (hit.distance < obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }
    }

   //Revives them to alive at the spawn point to begin the cycle again
   public void SetAlive(bool alive)
    {
        _alive = alive;
    }
}