using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

    public GameObject player;
    public GameObject music;
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
            Destroy(music);
            audio.Play();
            MyCoroutine();
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

    IEnumerator MyCoroutine()
    {
        yield return new WaitForSecondsRealtime(4);    //Wait one frame
    }
}
