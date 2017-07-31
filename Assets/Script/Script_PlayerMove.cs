using UnityEngine;
using System.Collections;

public class Script_PlayerMove: MonoBehaviour
{
	// speedを制御する
	public float speed = 10;
	void FixedUpdate ()
	{
		float x =  Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		//JUMP
		//if(Input.GetKeyDown(KeyCode.Space))
		//{GetComponent<Rigidbody>().AddForce(0,150,0, ForceMode.Acceleration);}
		// xとyにspeedを掛ける
		GetComponent<Rigidbody>().AddForce(x * speed, 0, z * speed);
	}

	void Update ()
{		//JUMP
		if(Input.GetButtonDown("Jump")||Input.GetKeyDown(KeyCode.Joystick1Button0))
		{GetComponent<Rigidbody>().AddForce(0,200,0, ForceMode.Acceleration);}
		//END
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();}
		if (Input.GetKey (KeyCode.End)) {
			Application.Quit ();
		}
	}

}
		