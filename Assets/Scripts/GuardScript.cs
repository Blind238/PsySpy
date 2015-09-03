using UnityEngine;
using System.Collections;

public class GuardScript : MonoBehaviour {

    private float selectionDelay = 1.2f;

    private float selectionStartTime;
    private GUIText Logger;

    private bool isColorFlipped = false;

    void OnMouseDrag () {
        if (selectionStartTime + selectionDelay <= Time.time) {
            //Logger.text = "Should change color";
            ChangeColor();
        }
    }

    void OnMouseDown() {
        selectionStartTime = Time.time;
    }

    void OnMouseUp () {

    }

    void ChangeColor() {
        if (!isColorFlipped) {
            GetComponent<SpriteRenderer>().color = Color.red;
        } else {
            GetComponent<SpriteRenderer>().color = Color.clear;
        }
        isColorFlipped = !isColorFlipped;
    }

	// Use this for initialization
	void Start () {
        //Logger = GameObject.Find("Logger").GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
