using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Junction : MonoBehaviour {

    public bool up;
    public bool down;
    public bool left;
    public bool right;

    private GameObject junctionUp = null;
    private GameObject junctionDown = null;
    private GameObject junctionLeft = null;
    private GameObject junctionRight = null;

    public void Start () {
        int i;

        // get the current Junction's coordinates
        string[] splitName = this.name.Split('.');
        int col = int.Parse(splitName[0].Split('(')[1]);
        int row = int.Parse(splitName[1].Split(')')[0]);
        print("col: " + col + "\nrow: " + row);

        // get the adjacent Junction objects
        if (up) {
            i = 1;
            while (junctionUp == null) {
                junctionUp = GameObject.Find("Junction (" + row + "." + (col + i) + ")");
                i++;
            }

            print(this.name + " up: " + junctionUp.name);
        }

        if (down) {
            i = 1;
            while (junctionDown == null) {
                junctionDown = GameObject.Find("Junction (" + row + "." + (col - i) + ")");
                i++;
            }

            print(this.name + " down: " + junctionDown.name);
        }

        if (left) {
            i = 1;
            while (junctionLeft == null) {
                junctionLeft = GameObject.Find("Junction (" + (row - i) + "." + col + ")");
                i++;
            }

            print(this.name + " left: " + junctionLeft.name);
        }

        if (right) {
            i = 1;
            while (junctionRight == null) {
                junctionRight = GameObject.Find("Junction (" + (row + i) + "." + col + ")");
                i++;
            }

            print(this.name + " right: " + junctionRight.name);
        }
    }

    public void OnTriggerEnter (Collider other) {
        if (other.gameObject.name == "Player") {
            
        }
    }
}
