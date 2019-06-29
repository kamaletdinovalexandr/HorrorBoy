using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;
	public static GameManager Instance { get { return _instance; } }

	private float _playerTime;
	public bool IsRunning;

	private void Awake() {
		_instance = this;
		_playerTime = 0;
		IsRunning = true;
	}

	internal void Win() {
		IsRunning = false;
		UIManager.Instance.ToggleMessage(true);
		UIManager.Instance.SetGameStatus("You Won!");
	}

	internal void GameOver() {
		IsRunning = false;
		UIManager.Instance.ToggleMessage(true);
		UIManager.Instance.SetGameStatus("Game Over!");
	}

	private void Update() {
		if (IsRunning) {
			_playerTime += Time.deltaTime;
			UIManager.Instance.UpdateScore(string.Format("{0:0.00}", _playerTime));
		}
	}
}
