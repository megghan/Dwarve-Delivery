using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Transform body;
    [SerializeField] float speed = 10f;
    [SerializeField] float turnSpeed = 20f;



    void Start()
    {
        
        
    }
      
    void Update()
    {
        MoveForward();
        TurnAround();
    }

    private void MoveForward()
    {
        float moveForward = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(0, moveForward, 0);
    }

    private void TurnAround()
    {
        float turnAround = Input.GetAxis("Horizontal") *Time.deltaTime*-turnSpeed;
        transform.Rotate(0, 0, turnAround);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("I hit with " + other.name);
    }
}
