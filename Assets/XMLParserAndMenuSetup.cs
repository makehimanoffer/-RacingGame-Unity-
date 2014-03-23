using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class XMLParserAndMenuSetup : MonoBehaviour {
	/*
	XDocument doc;
	List<MenuItem> setup;
	public GUISkin bla;
	public int numberOfItems;
	public List<bool> guiStuff;
	public List<int>  xPos;
	public List<int> yPos;
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
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(setup[0].ObjectType + " " + setup[0].TextValOrTextureName + " ");
		for(int i=0;i< numberOfItems;i++)
		{
			if(setup[i].X.Equals("Middle")){
				Debug.Log("GETTING HERE");
				xPos[i]=200;
			}
			if(setup[i].Y.Equals("Top")){
				yPos[i]=200;
			}
			Width[i]=setup[i].W;
			Height[i]=setup[i].Height;
			MenuString[i]= setup[i].TextValOrTextureName;


		}
	}
	void OnGUI(){

		GUI.Button(new Rect(Screen.width/2,Screen.height*.7f,100,100),"Hello");


	}
	*/
}
