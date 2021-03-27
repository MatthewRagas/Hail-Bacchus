using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTrigger : MonoBehaviour
{

    public GameObject player;
    public GameObject streetCar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Tell street car to stop using motor on hinge joints.
        //Stops street car
        streetCar = GameObject.Find("ground");
        HingeJoint[] hinges = streetCar.GetComponents<HingeJoint>();

        for(int i = 0; i < hinges.Length; i++)
        {
            hinges[i].useMotor = false;
        }

        //Teleports player to car exit point
        player = GameObject.Find("PlayerFBody");
        player.transform.position = new Vector3(4, 0, 17.5f);

        GameObject playerCamera = GameObject.Find("PlayerFBody/Female/PlayerCamera");
        playerCamera.enabled = true;

        GameObject trollyCamera = GameObject.Find("streetcar/TrollyCamera");
        trollyCamera.enabled = false;

        //Teleports invis back wall to stop car from rolling backwards
        GameObject invisWall = GameObject.Find("Invis Back Wall");
        invisWall.transform.position = new Vector3(0, -1, 11);
    }
}
