using UnityEngine;
using System.Collections;

// This is the class that will spawn objects over time
public class SpawnOverTimeScript : MonoBehaviour
{

    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;

    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;
    // Reference to the Renderer component
    private Renderer ourRenderer;

    // Use this for initialization
    void Start()
    {
        // Get the Renderer component
        ourRenderer = GetComponent<Renderer>();

        // Stop our Spawner from being visible!
        ourRenderer.enabled = false;

        // Call the given function after spawnDelay seconds, 
        // and then repeatedly call it after spawnDelay seconds.
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        // Calculate the left and right bounds of the spawn object
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
