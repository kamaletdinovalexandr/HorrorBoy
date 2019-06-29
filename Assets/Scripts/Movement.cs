using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] GameObject _lightning;
	[SerializeField] float _jumpForce;

    private void Update() {

		var force = new Vector3(_speed, 0, 0);
		if (Input.GetMouseButtonDown(0)) {
			force = new Vector3(force.x, _jumpForce, 0);
		}
		_rb.AddForce(force);
    }

    private void Shoot() {
        Instantiate(_lightning);
    }


}
