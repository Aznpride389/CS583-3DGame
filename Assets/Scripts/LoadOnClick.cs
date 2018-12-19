using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadOnClick : MonoBehaviour
{
    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Quit()
    {
        Application.Quit();
    }
   
    public void Home()
    {
        Debug.Log("Returning to main menu");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Main menu");
        SceneManager.UnloadSceneAsync(scene.name);
    }

}
