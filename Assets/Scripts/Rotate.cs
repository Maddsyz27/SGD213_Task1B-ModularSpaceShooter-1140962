using UnityEngine;
using System.Collections;

// This is the class that will rotate the object
public class Rotate : MonoBehaviour
{
    // The maximum spin speed of the object
    [SerializeField]
    private float maximumSpinSpeed = 200;

    // Use this for initialization
    void Start()
    {
        // Set the angular velocity of the object to a random value between -maximumSpinSpeed and maximumSpinSpeed
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
