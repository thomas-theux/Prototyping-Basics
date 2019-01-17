using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public int playerCount = 0;


	private void Awake() {
		GameVariables.playerCount = playerCount;
	}

}
