using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {
	[SerializeField] private Text _status;
	[SerializeField] private Button _restart;
	[SerializeField] private Text _score;

	private static UIManager _instance;
	public static UIManager Instance { get { return _instance; } }

	private void Awake() {
		_instance = this;
		Init();
	}

	private void Init() {
		_restart.onClick.AddListener(OnGameOverButtonClicked);
		ToggleMessage(false);
	}

	public void ToggleMessage(bool isActive) {
		_status.gameObject.SetActive(isActive);
		_restart.gameObject.SetActive(isActive);
	}

	public void SetGameStatus(string status) {
		_status.text = status;
	}

	private void OnGameOverButtonClicked() {
		_restart.onClick.RemoveListener(OnGameOverButtonClicked);
		SceneManager.LoadScene(0);
	}

	public void UpdateScore(string score) {
		_score.text = "Score: " + score;
	}
}
