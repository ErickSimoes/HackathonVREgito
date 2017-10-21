using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	public static GameObject player;

	void Start () {
		Game.player = GameObject.Find("Player");
	}

	void Update () {
		
	}
}
