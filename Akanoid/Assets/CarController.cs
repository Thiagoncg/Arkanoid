using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float movement;
    public float speed = 20f;
    public float carTorque = 10f;
    public Rigidbody2D bodyCarRigidBody;
    public Rigidbody2D frontTireRigidBody;
    public Rigidbody2D backTireRigidBody;
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        print("Movement: " + movement);
    }

    private void FixedUpdate()
    {
        frontTireRigidBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
        backTireRigidBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
        bodyCarRigidBody.AddTorque(-movement * carTorque * Time.fixedDeltaTime);
    }
}
