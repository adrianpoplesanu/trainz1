using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locomotive : MonoBehaviour {
    public Vector3 nextPosition;
    public float speed;

    void Start() {

    }

    void Update() {
        if (transform.position != nextPosition) {
            transform.position = Vector3.Lerp(transform.position, nextPosition, speed * Time.deltaTime);
        }
    }
}
