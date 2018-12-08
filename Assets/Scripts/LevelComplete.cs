using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public GameObject player;
    private bool gameOver;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(player);
            Scene loadedLevel = SceneManager.GetActiveScene();
            if (loadedLevel.name == "level3")
            {
                gameOver = true;
            }
            else if (loadedLevel.name == "level1")
            {
                SceneManager.LoadScene("level2");

            }
            else if (loadedLevel.name == "level2")
            {
                SceneManager.LoadScene("level3");

            }
        }
    }

}
