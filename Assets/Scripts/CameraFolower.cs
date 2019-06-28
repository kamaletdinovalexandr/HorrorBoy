using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolower : MonoBehaviour {
    [SerializeField] Transform _transform;

    private void FixedUpdate() {
        var newX = _transform.position.x;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
