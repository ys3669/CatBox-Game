using UnityEngine;
using System.Collections;


public class angel : MonoBehaviour {

	public int x,y,z;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(x,y,z);
	}
}
