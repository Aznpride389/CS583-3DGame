using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    float distance;
    Vector3 playerPrevPos, playerMoveDir;

    // Use this for initialization
    void Start () {
        //gets and set camera offset/distance and player intital position
        offset = transform.position - player.transform.position;
        distance = offset.magnitude;
        playerPrevPos = player.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        //gets player's direction of movement by takingits new position - old position
        playerMoveDir = player.transform.position - playerPrevPos;

        //if the player moved...
        if (playerMoveDir != Vector3.zero)
        {
            //points camer in direction of player new position
            playerMoveDir.Normalize();

            //moves camera to player new position - 
            transform.position = player.transform.position - playerMoveDir * distance;

            this.gameObject.transform.position += new Vector3(0, 5f, 0);

            transform.LookAt(player.transform.position);

            playerPrevPos = player.transform.position;
        }
    }
}
