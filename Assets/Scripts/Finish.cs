using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Finish : MonoBehaviour {


	public bool isPlayerCheating = false;



	void OnTriggerEnter(Collider carCollider)
	{
		bool playerWon = carCollider.tag == "PlayerTrigger";
		bool opponentWon = carCollider.tag == "OpponentTrigger";

		if (playerWon && !isPlayerCheating)
			GameObject.Find ("SceneController").GetComponent<SceneController> ().endGameStatus = "You won!";

		if (opponentWon) 
			GameObject.Find ("SceneController").GetComponent<SceneController> ().endGameStatus = "You lost!";

		if ((playerWon && !isPlayerCheating) || opponentWon)
			SceneManager.LoadScene ("GameEnd-v2");
	}
}
