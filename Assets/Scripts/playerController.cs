using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    //private Rigidbody2D rb2d;

    public Rigidbody rb;

    public float speed = 5.0f;

    //User can control rotation of player
    void Update()
    {
        float moveHorizontal = 0;
        float moveVertical = 0;

        // Tilts player with arrow keys as determined in Input settings
        //moveHorizontal = Input.GetAxis("Horizontal");
        //moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
