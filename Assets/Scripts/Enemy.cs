using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	private const string PLAYER_TAG = "Player";

	[SerializeField] private float _lifeTime;
	private float _lifetimeTimer = 0;

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == PLAYER_TAG) {
			GameManager.Instance.GameOver();
			Destroy(other.gameObject);
		}
	}

	private void Update() {
		_lifetimeTimer += Time.deltaTime;
		if (_lifetimeTimer > _lifeTime)
			Destroy(gameObject);
	}
}
