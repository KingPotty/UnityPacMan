using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junction : MonoBehaviour {

    public bool up;
    public bool down;
    public bool left;
    public bool right;

    public Junction junctionUp;
    public Junction junctionDown;
    public Junction junctionLeft;
    public Junction junctionRight;

    public void OnTriggerEnter (Collider other) {
        if (other.gameObject.name == "Player") {

        }
    }
}
