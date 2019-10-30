using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//нинзя-комментарий
public class UIButton : MonoBehaviour {

	[SerializeField] private GameObject targetObject;
	[SerializeField] private string targetMessage;

	public Color hightlightColor = Color.cyan;

	public void OnMouseEnter(){
		SpriteRenderer sprite = GetComponent<SpriteRenderer>();
		if(sprite != null){
			sprite.color = hightlightColor;
		}
	}

	public void OnMouseExit(){
		SpriteRenderer sprite = GetComponent<SpriteRenderer>();
		if(sprite != null){
			sprite.color = Color.white;
		}
	}

	public void OnMouseDown(){
		transform.localScale = new Vector3 (0.3f, 0.3f, 1);
	}

	public void OnMouseUp(){
		
		if(targetObject != null){
			targetObject.SendMessage(targetMessage);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
