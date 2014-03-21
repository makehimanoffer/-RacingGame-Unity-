using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class XMLParserAndMenuSetup : MonoBehaviour {
	XDocument doc;
	List<MenuItem> setup;
	public GUISkin bla;
	int numberOfItems;
	List<bool> guiStuff;

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
		}
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(setup[0].ObjectType + " " + setup[0].TextValOrTextureName + " ");
	}
	void OnGUI(){
		GUI.skin=bla;
		GUI.TextArea(new Rect(100,200,setup[0].W,setup[0].Height),setup[0].TextValOrTextureName);

	}
}
