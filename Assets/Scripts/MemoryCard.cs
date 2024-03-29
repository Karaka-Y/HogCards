﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//describes a behaviour of all cards in the scene
public class MemoryCard : MonoBehaviour {
	
	[SerializeField] private GameObject cardBack;
	[SerializeField] private SceneController controller;
	private int _id;
	public int Id{
		get {return _id;}
	}
	public void SetCard (int id, Sprite image){
		_id = id;
		GetComponent<SpriteRenderer>().sprite = image;
	}
	public void OnMouseDown() {
		if(cardBack.activeSelf && controller.canReveal){
			cardBack.SetActive(false);
			controller.CardRevealed(this);
		}
	}
	public void Unreveal() {
		cardBack.SetActive(true);
	}

	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
//added new comment