using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.GetComponent<Text> ().text = GameObject.Find ("SceneController").GetComponent<SceneController> ().endGameStatus;
	}
	

}
