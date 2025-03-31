using UnityEngine;
using System.Collections;

// This is the class that will move the bullet forward
public class BulletMoveForward : MonoBehaviour {
    // The acceleration of the bullet
    private float acceleration = 50f;
    // The initial velocity of the bullet
    private float initialVelocity = 5f;
    //  The reference to the Rigidbody2D component
    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // Get the Rigidbody2D component and store a reference to it
        ourRigidbody = GetComponent<Rigidbody2D>();
        //  Set the velocity of the bullet
        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // The force that will be added to the bullet
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        // Move the bullet in the direction passed in
        ourRigidbody.AddForce(ForceToAdd);
    }
}
