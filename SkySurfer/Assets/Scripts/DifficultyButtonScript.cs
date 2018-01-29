using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonScript : MonoBehaviour {

    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    //private SpriteRenderer spriteRenderer; 

    void Start()
    {
    //    Image i = GetComponent<Image>();
    //    Text t = b.GetComponentInChildren<Text>();
    //    spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
    //    if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
    //        spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }
	
	// Update is called once per frame
	void Update () {
        Image i = GetComponent<Image>();
        if (GlobalControl.Instance.getEasyMode()) {
            i.sprite = sprite2;
        } else {
            i.sprite = sprite1;
        }
	}

    public void swapDifficulty() {
        GlobalControl.Instance.swapMode();
    }

}
