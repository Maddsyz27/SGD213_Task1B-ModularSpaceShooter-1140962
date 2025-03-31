using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the class that will move the object
public class NewBehaviourScript : MonoBehaviour
{ // This is the direction the object will move in
    [SerializeField]
    private Vector2 direction;
    // This is the reference to the Movement script
    [SerializeField]
    private Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        // This gets the Movement script from the object
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.Move(direction);
    }
}
