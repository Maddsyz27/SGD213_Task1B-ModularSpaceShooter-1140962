using UnityEngine;
using System.Collections;

// This is the class that will move the object forward
public class EnemyMoveForward : MonoBehaviour  
{
    [SerializeField]
    // This is the acceleration of the object
    private float acceleration = 75f;
    // This is the initial velocity of the object
    private float initialVelocity = 2f;
    // This is the reference to the Rigidbody2D component
    private Rigidbody2D ourRigidbody;

    // Use this for initialization
    void Start()
    {
        // This gets the Rigidbody2D component
        ourRigidbody = GetComponent<Rigidbody2D>();
        // This sets the velocity of the object
        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // This is the force that will be added to the object
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        // This method moves the object in the direction passed in
        ourRigidbody.AddForce(ForceToAdd);
       
    }

}
