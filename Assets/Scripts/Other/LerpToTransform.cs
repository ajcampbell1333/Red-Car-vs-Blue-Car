using UnityEngine;
using System.Collections;

public class LerpToTransform : MonoBehaviour {

	public float speed;

	public Transform destination;

	Vector3 startPosition;



	void Start () {

		startPosition = transform.position;

	}


	void Update () {

		if (Mathf.Abs((transform.position - destination.position).magnitude) < 0.001f) {
			
			transform.position = destination.position;

		} else {
			
			transform.position = Vector3.Lerp(
				transform.position,
				destination.position,
				Time.deltaTime * speed
			);

		}


	}
}
