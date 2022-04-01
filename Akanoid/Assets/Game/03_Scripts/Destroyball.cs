using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyball : MonoBehaviour
{
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject collider = other.collider.gameObject;
        GameObject.Destroy(collider);
    }
}
