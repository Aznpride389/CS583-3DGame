using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public GameObject player;
    public GameObject music;
    private bool gameOver;

    public int curScene;

    void Start()
    {
        gameOver = false;
        //curScene = SceneManager.GetActiveScene().buildIndex;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(music);
            Destroy(player);

            if (curScene != 5)
            {
                int nextScene = curScene + 1;
                SceneManager.LoadScene(nextScene);
            }
            else
            {
                gameOver = true;
                var audio = GetComponent<AudioSource>();
                audio.Play();
                Invoke("Victory", 4f);
            }
        }
    }

    void Victory()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
