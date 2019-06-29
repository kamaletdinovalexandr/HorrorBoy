using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {
	[SerializeField] GameObject _enemyPrefab;
	[SerializeField] Transform _playerPosition;
	[SerializeField] float _instatiationDistance;
	[SerializeField] float _colldownDelta;
	[SerializeField] float _minY;
	[SerializeField] float _maxY;

	[Header("Difficulty")]
	[SerializeField] float _startCoolDown;
	[SerializeField] float _coolDownStep;
	[SerializeField] float _increaseDelta;


	private float _timer;
	private float _increaseTimer;

	private void Awake() {
		Init();
	}

	private void Init() {
		_timer = 0;
		_increaseTimer = 0;
		_colldownDelta = _startCoolDown;
	}

	private void Update() {
		if (!GameManager.Instance.IsRunning)
			return;

		_timer += Time.deltaTime;
		_increaseTimer += Time.deltaTime;

		if (_increaseTimer > _increaseDelta) {
			_increaseTimer = 0;
			_colldownDelta -= _coolDownStep;
			Debug.Log("Level Increased to " + _colldownDelta);
		}

		if (_timer > _colldownDelta) {
			_timer = 0;
			var positionX = _playerPosition.position.x + _instatiationDistance;
			var positionY = UnityEngine.Random.Range(_minY, _maxY);
			var position = new Vector3(positionX, positionY, 0);
			var go = Instantiate(_enemyPrefab, position, Quaternion.identity, transform);
			go.transform.RotateAround(go.transform.position, transform.up, 180f);
		}
	}
}
