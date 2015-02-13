
//Error occurs at line "lowPassValue = Mathf.Lerp(lowPassValue, Input.acceleration, LowPassFilterFactor);"
//Mathf.Lerp only works for float types. This should be changed to Vector3.Lerp function which takes in Vector3 variables.


using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour {

	public float speed=10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = 0;
		float z = 0;
		bool hasKeyboard = false;

		if (Input.GetKey (KeyCode.UpArrow)) {
						hasKeyboard = true;
						z += 0.1f;
				} else if (Input.GetKey (KeyCode.DownArrow)) {
						hasKeyboard = true;
						z -= 0.1f;

				} else if (Input.GetKey (KeyCode.LeftArrow)) {
						hasKeyboard = true;
						x -= 0.1f;
				} else if (Input.GetKey (KeyCode.RightArrow)) {
						hasKeyboard = true;
						x += 0.1f;
				}

		if (!hasKeyboard) {
			x=Input.acceleration.x;
			z=-Input.acceleration.z;
				}

		transform.Translate (x, 0, z);

	}
}