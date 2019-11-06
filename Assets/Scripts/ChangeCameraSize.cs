using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float aspect = (float)Screen.width / (float)Screen.height;
		if (aspect > 1.7f){
            Camera.main.orthographicSize = 5f;}
		else if (aspect == 1.6f){
			Camera.main.orthographicSize = 5.5f;}
		else if (aspect == 1.5f){
			Camera.main.orthographicSize = 6f;}
		else if (aspect < 1.4f && aspect > 1.3f){
			Camera.main.orthographicSize = 6.7f;}
		else if (aspect == 1.25f){
			Camera.main.orthographicSize = 7f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
