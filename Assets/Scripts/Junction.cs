 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junction : MonoBehaviour {

    public bool up;
    public bool down;
    public bool left;
    public bool right;

    public void Start () {
    }

    public void OnTriggerEnter (Collider other) {
        if (other.gameObject.name == "Player") {
            
        }
    }
}
