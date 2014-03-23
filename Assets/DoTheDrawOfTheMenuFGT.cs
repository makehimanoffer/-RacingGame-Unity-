	using UnityEngine;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Xml.Linq;

	public class DoTheDrawOfTheMenuFGT : MonoBehaviour {
		public Texture _image;
		XDocument doc;
		List<MenuItem> setup;
		public GUISkin bla;
		public int numberOfItems;
		public List<bool> guiStuff;
		public List<float>  xPos;
		public List<float> yPos;
		public List<float> Width;
		public List<float> Height;
		public List<string>MenuString;
		// Use this for initialization
		void Start () {
			doc=XDocument.Load("Assets/MenuItems.xml");
			setup= new List<MenuItem>();
			setup = (from items in doc.Descendants("Item")
			         select new MenuItem()
			         {
				ObjectType = items.Element("ObjectType").Value,
				TextValOrTextureName = items.Element("TextValOrTextureName").Value,
				X = items.Element("X").Value,
				Y = items.Element("Y").Value,
				W = float.Parse(items.Element("W").Value),
				Height = float.Parse(items.Element("H").Value)
			}).ToList();
			numberOfItems=setup.Count;
			guiStuff= new List<bool>();
			for(int i=0;i<numberOfItems;i++){
				guiStuff.Add(false);
				xPos.Add(0);
				yPos.Add(0);
				Width.Add(0);
				Height.Add(0);
				MenuString.Add("");
			}
		AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"); 
		AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity");					
		using(AndroidJavaObject ad = new AndroidJavaObject("com.unity.wrapper.LeadBoltUnity", jo))
		{
			ad.Call("loadAd", "153254736");
			
			// for Quick Start Ads
			// ad.Call("loadStartAd", "YOUR_LB_DISPLAY_AD_ID", "YOUR_LB_AUDIO_ID", "YOUR_LB_REENGAGEMENT_ID");
			
			// for Re-Engagement
			// ad.Call("loadReEngagement", "YOUR_LB_REENGAGEMENT_ID");
			
			// for Audio Ad
			// ad.Call("loadAudioAd", "YOUR_LB_SECTION_ID");
			
			// for Audio Track
			// ad.Call("loadAudioTrack", "YOUR_LB_SECTION_ID", 2);
		}

		}
		
		// Update is called once per frame
		void Update () {
			Debug.Log(setup[0].ObjectType + " " + setup[0].TextValOrTextureName + " ");
			for(int i=0;i< numberOfItems;i++)
			{
				
				if(setup[i].X.Equals("Middle")){
					Debug.Log("GETTING HERE");
					xPos[i]=Screen.width/2 - (setup[i].W/2);
				}
				if(setup[i].Y.Equals("Top")){
				yPos[i]=Screen.height*.2f + (i*100);
				}
				Width[i]=setup[i].W;
				Height[i]=setup[i].Height;
				MenuString[i]= setup[i].TextValOrTextureName;
				
				
			}
				

		}
		void OnGUI(){
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),_image);
			
			GUI.Label(new Rect(xPos[0],yPos[0],Width[0],Height[0]),MenuString[0]);
		if(GUI.Button(new Rect(xPos[1],yPos[1],Width[1],Height[1]),MenuString[1])){
				Application.LoadLevel("MainGame");
			}
		if(GUI.Button(new Rect(xPos[2],yPos[2],Width[2],Height[2]),MenuString[2])){
			Application.LoadLevel("Level2");
		}

		}


		void OnMouseDown(){
			Debug.Log("Getting here");

		}
		
	}
