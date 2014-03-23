using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Texture ArrowLeft;
	public Texture ArrowRight;
	public Texture ArrowUp;
	public Texture ArrowDown;
	bool up=false;
	bool down=false;
	bool left=false;
	bool right=false;
	float speed=50.0f;
	public float _turningSpeed;
	private Quaternion localRotation;

	public Vector2 _vel = new Vector2(0,0);
	public int number;
	// Use this for initialization
	void Start () {

		// copy the rotation of the object itself into a buffer
		localRotation = transform.rotation;
		//_vel = this.rigidbody2D.velocity;
	}

	// Update is called once per frame
	void Update () {

		
		// first update the current rotation angles with input from acceleration axis

		//localRotation.x += Input.acceleration.y * curSpeed;
		//localRotation.z += Input.acceleration.x * curSpeed;
		
		// then rotate this object accordingly to the new angle
		//transform.rotation = localRotation;
		this.gameObject.transform.Rotate(0,0,-Input.acceleration.x * _turningSpeed);
		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.y = Input.acceleration.y;
		
		// clamp acceleration vector to unit sphere
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		// Make it move 10 meters per second instead of 10 meters per frame...
		dir *= Time.deltaTime;
		
		// Move object
		transform.Translate (dir * speed );

			if(Input.GetKey(KeyCode.LeftArrow)){
				transform.Rotate(new Vector3(0,0,2),1f,0);
			}
			


			if(Input.GetKey(KeyCode.RightArrow)){
				transform.Rotate(new Vector3(0,0,-2),1f,0);
			}


			if(Input.GetKey(KeyCode.UpArrow)){
				transform.Translate(new Vector3(0,1,0)*Time.deltaTime*number);
			}


			if(Input.GetKey(KeyCode.DownArrow)){
				transform.Translate(new Vector3(0,-1,0)*Time.deltaTime*number);
			}

		/*
		if(left){

			transform.Rotate(new Vector3(0,0,1),.5f,0);


		}
		if(right){

			transform.Rotate(new Vector3(0,0,-1),.5f,0);

		}
		if(up){

			transform.Translate(new Vector3(0,1,0)*Time.deltaTime*number);

		}
		if(down){

			transform.Translate(new Vector3(0,-1,0)*Time.deltaTime*number);

		}
*/
	
	
	}
	void OnGUI(){
		if(GUI.Button(new Rect(0,Screen.height/2+60,60,60),ArrowLeft)){

			left=true;
			right=false;


		}
		else if(GUI.Button(new Rect(Screen.width/9,Screen.height/2+60,60,60),ArrowRight)){
			left=false;
			right=true;

		}


		if(GUI.Button(new Rect(Screen.width*.9f,Screen.height/2,60,60),ArrowUp)){
			up=true;

			down=false;
		}
		else if(GUI.Button(new Rect(Screen.width*.9f,Screen.height/2+60,60,60),ArrowDown)){
			up=false;

			down=true;
		}


	}
}
