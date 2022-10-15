using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPoint : MonoBehaviour {
    public Vector3 coordinates;
    public TrackPoint next;
    public Quaternion targetRotation;
    public TrackSelector trackSelector;

    void Start() {
        switch (trackSelector) {
            case TrackSelector.STRAIGHT:
                Debug.Log("loading a straight point");
            break;
            case TrackSelector.LEFT1:
                Debug.Log("loading a left1 point");
            break;
            default:
                Debug.Log("unknown point setup");
            break;
        }
    }

    void Update() {
        
    }

    public enum TrackSelector {
        STRAIGHT,
        LEFT1
    }
}
