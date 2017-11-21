using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void gameScene()
    {
        SceneManager.LoadScene("gameScene");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
