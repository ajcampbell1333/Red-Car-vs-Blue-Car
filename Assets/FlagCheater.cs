using UnityEngine;
using System.Collections;

public class FlagCheater : MonoBehaviour {

	void OnTriggerExit(Collider playerCar)
	{
		Debug.Log ("trigger fired");

		if (playerCar.tag == "PlayerTrigger") {


			bool currentState = GameObject.Find ("FinishLine").GetComponent<Finish> ().isPlayerCheating;
			GameObject.Find ("FinishLine").GetComponent<Finish> ().isPlayerCheating = !currentState;
		}
	}


}
