using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {
    private InputManager inputManager;
    void Start() {
        inputManager = new InputManager();        
    }

    public bool forwardKeyPressed() {
        return Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);
    }

    public bool backwardKeyPressed() {
        return false;
    }

    public bool leftKeyPressed() {
        return false;
    }

    public bool rightKeyPressed() {
        return false;
    }

    public Vector2 getMouseCoordinates() {
        return Vector2.zero;
    }
}
