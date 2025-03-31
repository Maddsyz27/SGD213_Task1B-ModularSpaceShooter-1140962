using UnityEngine;
using System.Collections;

// This is the class that will move the player
public class PlayerMovementScript : MonoBehaviour 
{
            // SerializeField exposes this value to the Editor, but not to other Scripts!
        
            // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
            [SerializeField]
            private float horizontalPlayerAcceleration = 5000f;

            private Rigidbody2D OURRigidbody;

    // Use this for initialization
    void Start() 
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
        OURRigidbody = GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void Update()
    {// Get the Horizontal Input from the player
        float HorizontalInput = Input.GetAxis("Horizontal");

        // If the player is pressing the Horizontal Input, then move the player
        if (HorizontalInput != 0.0f)
        {// Calculate the force to add to the player
            Vector2 ForceToAdd=Vector2.right*HorizontalInput*horizontalPlayerAcceleration*Time.deltaTime;
            OURRigidbody.AddForce(ForceToAdd);
            //print(HorizontalInput);
        } 
    } 
}
