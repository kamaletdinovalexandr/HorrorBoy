using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed = 5f;
    [SerializeField] GameObject _lightning;

    private void Update() {
        var newPosition = new Vector3(_speed * Time.deltaTime, 0, 0);

        if (Input.GetMouseButtonDown(1)) {
            newPosition = new Vector3(newPosition.x, 200, newPosition.z);
        }

       
        if (Input.GetMouseButtonDown(0)) {
            //Shoot();
        }
        _rb.AddForce(newPosition);
    }

    private void Shoot() {
        Instantiate(_lightning);
    }
}
