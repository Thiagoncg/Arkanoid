using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Phisic control the ball

    [SerializeField]
    private Vector2 _speed;
    void Start()
    {
       Rigidbody2D rb = GetComponent<Rigidbody2D>();
       rb.AddForce(_speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
