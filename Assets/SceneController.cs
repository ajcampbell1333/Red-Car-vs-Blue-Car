using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

	public string endGameStatus;

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}
	

}
