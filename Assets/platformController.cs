using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformController : MonoBehaviour {

    //private Rigidbody2D rb2d;

    public Rigidbody rb;

    public float speed = 5.0f;

    //User can control rotation of player
    void Update()
    {
        // Tilts player with arrow keys as determined in Input settings
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
