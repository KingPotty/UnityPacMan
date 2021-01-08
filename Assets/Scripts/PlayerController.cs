using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private int speed;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        direction = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(0, 0, 90, 0);
        if (Input.GetAxis("Horizontal") > 0) {
            print("right");
            direction = Vector3.right;
            transform.rotation = new Quaternion(0, 0, 0, 0);
        } else if (Input.GetAxis("Horizontal") < 0) {
            print("left");
            direction = Vector3.left;
            transform.rotation = new Quaternion(0, 0, 180, 0);
        } else if (Input.GetAxis("Vertical") > 0) {
            print("up");
            direction = Vector3.up;
            transform.rotation = new Quaternion(0, 0, 270, 0);
        } else if (Input.GetAxis("Vertical") < 0) {
            print("down");
            direction = Vector3.down;
            transform.rotation = new Quaternion(0, 0, 90, 0);
        }
        transform.position += speed * direction * Time.deltaTime;
    }

    private void OnTriggerEnter (Collider collision) {
        print("ow");
        speed = 0;
    }

    private void OnTriggerExit (Collider collision) {
        speed = 1;
    }
}
