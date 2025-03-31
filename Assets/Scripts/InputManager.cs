using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the class that will manage the input
public class InputManager : MonoBehaviour
{
    // This is the reference to the Movement component
    private Movement Movement;
    private ShootingScript shooting;


    // Start is called before the first frame update
    void Start()
    {
        // Get the Movement component
        Movement = GetComponent<Movement>();
        shooting = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input
        float input = Input.GetAxis("Horizontal");

        //  Move the object in the direction of the input
        Movement.Move(Vector2.right * input);
    }
}
