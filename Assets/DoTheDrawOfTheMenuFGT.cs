using UnityEngine;
using System.Collections;

public class DoTheDrawOfTheMenuFGT : MonoBehaviour {
	public Texture _image;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
			

	}
	void OnGUI(){
		GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),_image);
		if(GUI.Button(new Rect(Screen.width/2,Screen.height*.7f,100,100),"Press Me")){
			Application.LoadLevel("MainGame");
		}
	}


	void OnMouseDown(){
		Debug.Log("Getting here");

	}
	
}
