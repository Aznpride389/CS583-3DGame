using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldController : MonoBehaviour {

    public float TiltX = 0f;
    public float TiltY = 0f;

    //User can control rotation of player
    void FixedUpdate()
    {
        TiltX += Input.GetAxis("Horizontal");
        transform.eulerAngles = new Vector3(TiltX, 5, 0);

        TiltY += Input.GetAxis("Vertical");
        transform.eulerAngles = new Vector3(5, TiltY, 0);

    }


}

