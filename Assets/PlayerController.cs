using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private float moveHorizontal;
    private float moveVertical;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }


    void FixedUpdate()
    {
        if (moveHorizontal != 0 || moveVertical != 0)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            // rb.AddForce(movement * speed);
            rb.velocity = movement * speed;
        }
    }
}
