using UnityEngine;
using System.Collections;

// This is the class that will destroy the object when it leaves the viewport
public class DestroyedOnExit : MonoBehaviour
{

    // Called when the object leaves the viewport
    void OnBecameInvisible()
    {
        // Destroy the object
        Destroy(gameObject);
    }
}
