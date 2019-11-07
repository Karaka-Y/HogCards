using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthographicSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float screenRatio = (float)Screen.width / (float)Screen.height;
		float targetRatio = 1.8f;

		if(screenRatio >= targetRatio){
			Camera.main.orthographicSize = 5f;
		}
		else{
			float differenceInSize = targetRatio / screenRatio;
			Camera.main.orthographicSize = 5f * differenceInSize;
		}

	}
}
