using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PushSpaceToStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextScene();
        }
		
	}

    public void nextScene()
    {
        SceneManager.LoadScene("test2", LoadSceneMode.Single);
    }

}
