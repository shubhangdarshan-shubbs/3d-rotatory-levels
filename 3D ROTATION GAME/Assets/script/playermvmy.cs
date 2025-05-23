using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermvmy : MonoBehaviour
{
    [Header("MOVEMENT")]
    public float moveSpeed = 6f;

    float horizontalmovement;
    float verticalmovement;

    Vector3 movedirection;

    Rigidbody rb;


    private void start()
    {

        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        MyInput();
    }

    void MyInput()
    {
        horizontalmovement = Input.GetAxisRaw("Horizontal");
        verticalmovement = Input.GetAxisRaw("Vertical");
        movedirection = transform.forward * verticalmovement + transform.right * horizontalmovement;
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.AddForce(movedirection.normalized *moveSpeed, ForceMode.Acceleration);
    }
    
}
