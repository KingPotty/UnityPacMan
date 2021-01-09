using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private int speed;
    private Vector3 direction;
    private string savedDirection = "";

    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        direction = Vector3.right;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction.x != 0) {
            // Vertical input while moving vertically
            if (Input.GetAxis("Vertical") > 0) {
                savedDirection = "up";
            } else if (Input.GetAxis("Vertical") < 0) {
                savedDirection = "down";
            
            // Horizontal input while moving vertically
            } else if (Input.GetAxis("Horizontal") < 0) {
                direction = Vector3.left;
                savedDirection = "";
            } else if (Input.GetAxis("Horizontal") > 0) {
                direction = Vector3.right;
                savedDirection = "";
            }

        } else {
            // Horizontal input while moving horizontally
            if (Input.GetAxis("Horizontal") < 0) {
                savedDirection = "left";
            } else if (Input.GetAxis("Horizontal") > 0) {
                savedDirection = "right";

            // Vertical input while moving horizontally
            } else if (Input.GetAxis("Vertical") > 0) {
                direction = Vector3.up;
                savedDirection = "";
            } else if (Input.GetAxis("Vertical") < 0) {
                direction = Vector3.down;
                savedDirection = "";
            }
        }
        transform.position += speed * direction * Time.deltaTime;
    }

    private void OnTriggerEnter (Collider collision) {
        print(collision.gameObject.name);
        if (!collision.gameObject.name.StartsWith("Cube")) {
            print("fuck");
            return;
        }

        Junction junction = collision.gameObject.GetComponent<Junction>();

        if ((savedDirection == "up") && junction.up) {
            print("moving up");
            direction = Vector3.up;
            savedDirection = "";
        } else if ((savedDirection == "down") && junction.down) {
            print("moving down");
            direction = Vector3.down;
            savedDirection = "";
        } else if ((savedDirection == "left") && junction.left) {
            print("moving left");
            direction = Vector3.left;
            savedDirection = "";
        } else if ((savedDirection == "right") && junction.right) {
            print("moving right");
            direction = Vector3.right;
            savedDirection = "";

        } else if (!(((direction == Vector3.up) && junction.up)
                || ((direction == Vector3.down) && junction.down)
                || ((direction == Vector3.left) && junction.left)
                || ((direction == Vector3.right) && junction.right))) {

            print("stopping");
            direction = Vector3.zero;
        } else {
            print("carrying on");
        }
    }
}
