using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawn : MonoBehaviour {

	public GameObject playerGO;
	public Vector3 defaultSpawnPosition = new Vector3(0, 1, 0);
	public float playerSpawnDistance = 4.0f;


	// Spawn new players with the amount set in GameVariables
	private void Start() {
		for (int i = 0; i < GameVariables.playerCount; i++) {
			GameObject newPlayer = Instantiate(playerGO);
			newPlayer.name = "Player" + i;
			newPlayer.transform.position = defaultSpawnPosition + new Vector3(playerSpawnDistance * i, 0, 0);
		}
	}

}