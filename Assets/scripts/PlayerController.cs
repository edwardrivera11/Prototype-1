using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

   private float turnSpeed = 60;
   private float speed = 50;
   private float horizontalInput;
   private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // moves the car forward based on vertical input
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // rotates the car based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

}
