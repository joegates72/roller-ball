using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
rb = GetComponent<Rigidbody>();
    }
     void OnMove (InputValue movementValue) 
{
   Vector2 movementVector = movementValue.Get<Vector2>(); 
}

       
void FixedUpdate()
{
    rb.AddForce(movementVector);
}


