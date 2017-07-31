using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public UnityEngine.UI.Text scoreLabel;
	public GameObject winnerLabelObject;
	private int score,time;
	public void Start (){
	}
	public void Update ()
	{	
		GameObject[] Cat = GameObject.FindGameObjectsWithTag ("item");
		time++;
		if (Cat.Length == 0) {
        	Debug.Log("NoCat");
		}
		scoreLabel.text = (string)Cat.Length.ToString();
		if (Cat.Length == 0) {
			// オブジェクトをアクティブにする
			winnerLabelObject.SetActive (true);
				if(score==0){
				score= time;
				}
		scoreLabel.text = "" + score;
		}
	}
}