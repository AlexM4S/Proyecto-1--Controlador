using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Velocidad de movimiento
    private float speed = 20;
    // Velocidad de giro
    private float turnSpeed = 100;

    private float horizontalInput;
    private float verticalInput;

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotación
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
