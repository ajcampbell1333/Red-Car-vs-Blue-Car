using UnityEngine;
using System.Collections;

public class LerpAnyAxis : MonoBehaviour {

	public float speed;

	Vector3 startPosition, destinationPosition;

	public bool lerpX, lerpY, lerpZ;

	public float distance;

	float xVal = 0, yVal = 0, zVal = 0;


	void Start () {
		
		if (lerpX)
			xVal = distance;
		if (lerpY)
			yVal = distance;
		if (lerpZ)
			zVal = distance;

		startPosition = transform.position;
		destinationPosition = new Vector3 (xVal, yVal, zVal) + startPosition;
	}


	void Update () {

		if (Mathf.Abs((transform.position - destinationPosition).magnitude) < 0.001f) {
			
			transform.position = destinationPosition;

		} else {
			//Debug.Log (destinationPosition);
			transform.position = Vector3.Lerp(
				transform.localPosition,
				destinationPosition,
				Time.deltaTime * speed
			);

		}


	}
}
