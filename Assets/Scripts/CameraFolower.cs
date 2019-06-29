using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolower : MonoBehaviour {
    [SerializeField] Transform _transform;
	[SerializeField] float _cameraOffset;

    private void Update() {
		if (_transform == null)
			return;

        var newX = _transform.position.x - _cameraOffset;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
