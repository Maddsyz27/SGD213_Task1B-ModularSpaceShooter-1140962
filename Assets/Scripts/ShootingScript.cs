using UnityEngine;
using System.Collections;

// This is the class that will shoot bullets
public class ShootingScript : MonoBehaviour
{
    
    [SerializeField]
    private GameObject bullet;
    // This is the last time we fired a bullet
    private float lastFiredTime = 0f;
    // This is the delay between bullets
    [SerializeField]
    private float fireDelay = 1f;
    // This is the offset of the bullet from the player
    private float bulletOffset = 2f;
    
    void Start()
    {
        // Calculate the offset of the bullet from the player
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is pressing the Fire1 button, then shoot a bullet
        if (Input.GetButton("Fire1"))
        {
            // Get the current time
            float CurrentTime = Time.time;

            // If the current time minus the last time we fired a bullet is greater than the delay between bullets
            if (CurrentTime - lastFiredTime > fireDelay)
            {
                // Calculate the spawn position of the bullet
                Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
                // Spawn the bullet at the spawnPosition
                Instantiate(bullet, spawnPosition, transform.rotation);
                // Update the last time we fired a bullet
                lastFiredTime = CurrentTime;
            }

            //print("Shoot!");
        }
    }
    public void Shoot()
    {
        float CurrentTime = Time.time;
        // If the current time minus the last time we fired a bullet is greater than the delay between bullets
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            // Calculate the spawn position of the bullet
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
            // Spawn the bullet at the spawnPosition
            Instantiate(bullet, spawnPosition, transform.rotation);
            // Update the last time we fired a bullet
            lastFiredTime = CurrentTime;
        }
    }
    


    /// <summary>
    /// SampleMethod is a sample of how to use abstraction by
    /// specification. It converts a provided integer to a float.
    /// </summary>
    /// <param name="number">any integer</param>
    /// <returns>the number parameter as a float</returns>
    public float SampleMethod(int number) 
    {
        return number;
    }

}
