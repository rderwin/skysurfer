using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
 
 
    public void nextScene()
    {
        SceneManager.LoadScene("test2", LoadSceneMode.Single);
    }


}

