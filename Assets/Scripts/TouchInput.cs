using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
		bool suppMultiTouch = Input.multiTouchEnabled;

		print ("MultiTouchSupport: " + suppMultiTouch);

	}
	
	// Update is called once per frame
	void Update () {
		int numTouch = Input.touchCount;

		if (numTouch > 0) {

			for(int i=0 ;i<numTouch;i++){

				Touch touch=Input.GetTouch(i);

				if(touch.phase ==TouchPhase.Began){

					Ray sRay=Camera.main.ScreenPointToRay(touch.position);

					RaycastHit hit;

					if(Physics.Raycast(sRay, out hit)){
						if(hit.collider.gameObject.tag=="ball"){
						Destroy(hit.collider.gameObject);
						}
					}
				}

			}

		}

		else if(Input.GetMouseButtonDown(0)){
			Ray sRay=Camera.main.ScreenPointToRay(Input.mousePosition);
			
			RaycastHit hit;
			
			if(Physics.Raycast(sRay, out hit)){
				
				if(hit.collider.gameObject.tag=="ball"){
					Destroy(hit.collider.gameObject);
				}
				
			}
			
		}


	}

	
}
