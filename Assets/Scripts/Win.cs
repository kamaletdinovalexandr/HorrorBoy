using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {
	private const string PLAYER_TAG = "Player";

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == PLAYER_TAG) {
			GameManager.Instance.Win();
			Destroy(other.gameObject);
		}
	}
}
