using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class button_Exit : MonoBehaviour {

    // Use this for initialization
    public void exitToMenu()
    {
        Debug.Log("Returning to main menu");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Main menu");
        SceneManager.UnloadSceneAsync(scene.name);
    }

}
