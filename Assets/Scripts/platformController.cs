using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour {

    //private Rigidbody2D rb2d;
    public float speed = 1.5f;
    public float moveVertical;
    public float moveHorizontal;

    //User can control rotation of player
    void Update()
    {
        moveHorizontal = (-1) * Input.GetAxis("Horizontal") * speed;
        moveVertical = Input.GetAxis("Vertical") * speed;

        this.transform.Rotate(new Vector3(moveVertical, 0, moveHorizontal));
    }

    private void Start()
    {
        
    }
}
