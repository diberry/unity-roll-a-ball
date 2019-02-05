  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    // called on first frame game is active
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //update - before rendering frame
    void Update()
    {


    }
    //fixed update -- before physics
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);


    }
}
