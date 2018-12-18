using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallOff : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter ()
    {
        Invoke("Restart", .5f);	
	}
	
	// Update is called once per frame
	void Restart ()
    {
        Scene curScene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(curScene.buildIndex);
	}
}
