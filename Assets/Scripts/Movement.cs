using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the class that will move the object
public class Movement : MonoBehaviour
{
    // This is the acceleration of the object
    [SerializeField]
    private float acceleration = 75f;
    // This is the reference to the Rigidbody2D component
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // This method moves the object in the direction passed in
    public void Move(Vector2 direction)
    {
        // This is the force that will be added to the object
        rb.AddForce(direction * acceleration * Time.deltaTime);
    }
}
