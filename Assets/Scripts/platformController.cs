using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour {
    public GameObject player;
    public GameObject floor;

    //private Rigidbody2D rb2d;
    public float speed = .5f;
    public float moveVertical;
    public float moveHorizontal;
    public float timeMove;

    private float tiltAngle = 60f;
    private float smooth = 5f;


    //User can control rotation of player
    void Update()
    {
        //Gets arrow key input to tilt world
        moveHorizontal = (-1) * Input.GetAxis("Horizontal") * speed * tiltAngle;
        moveHorizontal = Mathf.Clamp(moveHorizontal, -30, 30); //Stops horizontal tilt of more than 30 degrees
        moveVertical = Input.GetAxis("Vertical") * speed * tiltAngle;
        moveVertical = Mathf.Clamp(moveVertical, -30, 30); //Stops vertical tilt of more than 30 degrees

        //Determines target rotation of input
        Quaternion target = Quaternion.Euler(moveVertical, 0, moveHorizontal);

        //set time to move with scale
        timeMove = Vector2.Distance(new Vector2(player.transform.position.x, player.transform.position.z), new Vector2(0, 0));
        timeMove = 1 - (timeMove / new Vector2(floor.GetComponent<MeshRenderer>().bounds.size.x, floor.GetComponent<MeshRenderer>().bounds.size.z).magnitude);
        timeMove = Time.deltaTime * timeMove;


        //Rotates smoothly at adjusted speed
        transform.rotation = Quaternion.Slerp(transform.rotation, target, timeMove * smooth);

        //If arrows are not pressed, return to default rotation
        if(moveHorizontal == 0 && moveVertical == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, timeMove * 2);
        }
    }

}
