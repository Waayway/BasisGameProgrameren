using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    private float speed = 20;

    private float turnSpeed = 40;

    private float horizontalInput = 0;

    private float forwardInput = 0;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update(){
        // Get Input from wasd/arrow keys as defined in unity
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Apply the forward motion.
        transform.Translate(Vector3.forward *Time.deltaTime * speed  * forwardInput );
        // Apply the rotational motion
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed *  horizontalInput);
    }
}
