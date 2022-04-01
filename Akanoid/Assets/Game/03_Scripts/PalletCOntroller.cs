using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletCOntroller : MonoBehaviour
{
    //Control pallet right and Left
    [SerializeField]
    private float _speed;
    
    [SerializeField]
    private float _horizontalAxis;

    [SerializeField]
    private Rigidbody2D rb;
    void Update()
    {
        ControllPallete();
    }
    private void ControllPallete()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(_speed * _horizontalAxis, 0);
    }
}
