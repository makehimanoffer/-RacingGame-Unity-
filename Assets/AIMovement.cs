using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIMovement : MonoBehaviour {
	public float generalMoveSpeed;
	public bool goingRight=true;

	public GameObject [] WayPoints;
	public List<Rect> WayPointRects;
	public List<Vector2> WayPoints2d;
	public Rect thisRect;
	public int currentWaypoint=0;
	// Use this for initialization
	void Start () {
	
		for(int i=0;i<WayPoints.Length;i++){
			WayPointRects.Add(new Rect(WayPoints[i].transform.position.x,WayPoints[i].transform.position.y,50.0f,50.0f));
			WayPoints2d.Add(new Vector2(WayPoints[i].transform.position.x,WayPoints[i].transform.position.y));
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(new Rect(transform.position.x,transform.position.y,100,100).Overlaps(WayPointRects[currentWaypoint])){
			if(currentWaypoint<WayPoints.Length){
			currentWaypoint++;
			}
			if(currentWaypoint>=WayPoints.Length){
				currentWaypoint=0;
			}


		}
		transform.LookAt(new Vector3(WayPoints[currentWaypoint].transform.position.x,WayPoints[currentWaypoint].transform.position.y,0));
		this.rigidbody2D.velocity+=new Vector2(this.rigidbody2D.transform.forward.x,this.rigidbody2D.transform.forward.y);
	}
}
