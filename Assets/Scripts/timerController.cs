using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timerController : MonoBehaviour {

    public GameObject player;
    public GameObject miniCam;
    public GameObject miniMap;
    public float speed = 15.0f;

    public Text timeText;
    public float time;

    private Vector3 cur = Vector3.zero;

    // Use this for initialization
    void Start () {
        time = 30;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        time -= Time.deltaTime;
        timeText.text = time.ToString("0.0");

        if (time <= 0.5)
        {
            Invoke("Restart", .5f);
        }

        miniCam.transform.position = Vector3.SmoothDamp(miniCam.transform.position, (player.transform.position + new Vector3(0, 10, 0)), ref cur, .01f, speed);
        //miniCam.transform.LookAt(player.transform);
    }
    void Restart()
    {
        Scene curScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(curScene.buildIndex);
    }
}
