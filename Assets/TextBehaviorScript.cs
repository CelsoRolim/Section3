using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextBehaviorScript : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Press any key to start.";
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.Return)) {
			text.text = "Key return pressed.";
		}
	}
}
