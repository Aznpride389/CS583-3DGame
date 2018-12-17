using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public GameObject player;
    private bool gameOver;

    public int curScene;
    public int nextScene;

    void Start()
    {
        gameOver = false;

        curScene = SceneManager.GetActiveScene().buildIndex;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var audio = GetComponent<AudioSource>();
            audio.Play();
            Destroy(player);

            if (curScene != 2)
            {
                nextScene = curScene + 1;
                SceneManager.LoadScene(nextScene);
            }
            else
            {
                gameOver = true;
                //SceneManager.LoadScene("VictoryScene");
            }
        }
    }
}
