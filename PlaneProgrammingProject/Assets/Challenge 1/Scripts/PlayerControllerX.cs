using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate... moves at a speed of 15m per frame when you multiply speed by Time.deltaTime
        transform.Translate(Vector3.forward * speed * Time.deltaTime );

        // tilt the plane up/down based on up/down arrow keys... multiply by verticalInput to be able to control the plane up or down
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
