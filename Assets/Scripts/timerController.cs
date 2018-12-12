using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timerController : MonoBehaviour {

    public float time;
    public Text timeText;
	// Use this for initialization
	void Start () {
        time = 30;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        time -= Time.deltaTime;
        timeText.text = time.ToString("0.0");
	}
}
