using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //privert variable
    private float speed = 5.0f;
    private float turnSpeed = 25.0f ; 
    private float hurizontalMovement;
    private float forwardMovement;

    // Update is called once per frame
    void Update()
    {
        // getting inputs
        hurizontalMovement = Input.GetAxis("Horizontal");
        forwardMovement = Input.GetAxis("Vertical");

        //translating and rotating the player in x y and z
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardMovement);
        transform.Rotate(Vector3.up *Time.deltaTime * turnSpeed * hurizontalMovement);
    }
}
