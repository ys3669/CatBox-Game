
using UnityEngine;
using System.Collections;

public class Get_anime: MonoBehaviour {
	[SerializeField]
	Animator mAnimator;// InspectorでAnimatorを指定しておく
	//[SerializeField]
	//private GameObject prefab; // Inspectorでobjを指定しておく
	void Update () {

		AnimatorStateInfo stateInfo = mAnimator.GetCurrentAnimatorStateInfo(0);
		// レイヤーのインデックスを引数に指定

		if (stateInfo.IsName ("Base.stopEND")) {
				this.GetComponent<BoxCollider> ().isTrigger = false;
			//	Debug.Log("closeNow_false");
		}
		if( stateInfo.IsName("Base.open") ) {
			
			this.GetComponent<BoxCollider> ().isTrigger = true;
			//	Debug.Log("closeNow_true");
		}
	}
}