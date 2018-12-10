using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour {

    public GameObject player;
    public GameObject camera;

    public float setAbove = 3.0f;
    public float setBack = 4.0f;
    public float speed = 5.0f;

    private Vector3 playerCurPos = new Vector3();
    private Vector3 playerPrevPos = new Vector3();
    private Vector3 cur = Vector3.zero;

    // Use this for initialization
    void Start () {
        playerCurPos = player.transform.position;
        playerPrevPos = playerCurPos;

        camera = gameObject.GetComponent<Camera>().gameObject;
        camera.transform.position = playerCurPos + new Vector3(0, setAbove, -setBack);
        camera.transform.LookAt(player.transform);
    }
	
	// Update is called once per frame
	void LateUpdate () {
        playerCurPos = player.transform.position;

        chkCam();

        playerPrevPos = playerCurPos;
	}

    void chkCam()
    {
        Vector3 playerMoveDir = playerCurPos - playerPrevPos;
        playerMoveDir.Normalize();
        Vector3 pivot = (player.transform.position - setBack * playerMoveDir);

        Vector3 POS = pivot + Vector3.up * setAbove;

        if (playerMoveDir != Vector3.zero)
        {
            transform.LookAt(player.transform.position);
            //transform.position = Vector3.MoveTowards(transform.position, POS, .1f);
            transform.position = Vector3.SmoothDamp(transform.position, POS, ref cur, .05f, speed);
            transform.LookAt(player.transform.position);

            //cur = 0;
        }
        
    }
}
