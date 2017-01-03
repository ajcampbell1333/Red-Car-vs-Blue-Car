using UnityEngine;
using System.Collections;

public class SlerpAnyAxis : MonoBehaviour {

	public float speed;

	Quaternion newQuat, destinationQuat;
	public bool x, y, z;
	public float rotationValue;
	float xVal = 0, yVal = 0, zVal = 0;

	// Use this for initialization
	void Start () {
		newQuat = Quaternion.identity;
		if (x)
			xVal = rotationValue;
		if (y)
			yVal = rotationValue;
		if (z)
			zVal = rotationValue;
		
		destinationQuat.eulerAngles = new Vector3 (xVal, yVal, zVal);
	}

	// Update is called once per frame
	void Update () {

		if (transform.rotation.eulerAngles.y > rotationValue - 0.0001f) {
			
			transform.rotation = destinationQuat;

		} else {
			
			newQuat = Quaternion.Slerp(
				newQuat,
				destinationQuat,
				Time.deltaTime * speed
			);
			transform.rotation = newQuat;

		}




		/*
		newQuat.eulerAngles = new Vector3 (
											transform.rotation.eulerAngles.x, 
											transform.rotation.eulerAngles.y + 1.0f,
											transform.rotation.eulerAngles.z
										  );
		transform.rotation = newQuat;
		*/




	}
}
