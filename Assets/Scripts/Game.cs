using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public static GameObject player;

	// Use this for initialization
	void Start () {
		Game.player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
