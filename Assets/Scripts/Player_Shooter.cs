using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Shooter : MonoBehaviour
{
    //A public and private method that sets the players ammo to 60 and attaches the camera to the player
	public int ammo = 60;
    private Camera playerCam;

   
   //A getcomponent that puts a cross hair for the player acting as an aim on the camera putting the mouse cursor to invisible
   void Start()
    {
        playerCam = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
		//an if else statement occurring if the player is out of ammo they cannot shoot any more enemy
            if (ammo > 0) {


                ammo--;
                Vector3 point = new Vector3(playerCam.pixelWidth / 2, playerCam.pixelHeight / 2, 0);
                Ray ray = playerCam.ScreenPointToRay(point);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    //An if else statement allowing the enemy to be hit by bullets causing them to die when shot.
					GameObject hitObject = hit.transform.gameObject;

                    Enemy_Shot target = hitObject.GetComponent<Enemy_Shot>();

                    if (target != null)
                    {
                        target.GotShot();
                    }
                    else
                    {
                        StartCoroutine(ShotGen(hit.point)); //Launch a coroutine in response to a hit!
                    }

                }
            }
            else
            {
                print("click");
            }
        }
    }

   //A effect allowing a tiny sphere to show up whenever the walls are hit
   private IEnumerator ShotGen(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        sphere.transform.position = pos;

        yield return new WaitForSeconds(1);

        Destroy(sphere);
    }

    //Setting up the dimensions of the camera
	void OnGUI()
    {
        int size = 12;
        float posX = playerCam.pixelWidth / 2 - size / 4;
        float posY = playerCam.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }
    
	//A public method getting and returning the ammo
	public int getAmmo()
    {
        return ammo;
    }
}
