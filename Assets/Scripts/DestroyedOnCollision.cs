using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This is the type of list we are using
public enum TagListType
{
    // Blacklist: Destroy if the tag IS in the Blacklist
    Blacklist,
    // Whitelist: Destroy if the tag is NOT in the Blacklist
    Whitelist
}
// This is the class that will destroy the object when it collides with another object
public class DestroyedOnCollision : MonoBehaviour
{

    [SerializeField]
    private TagListType tagListType = TagListType.Blacklist;

    // A list of tags which we use to determine whether to explode or not
    // Depending on the tagListType (Blacklist or Whitelist)
    [SerializeField]
    private List<string> tags;
    // This function is called when the object collides with another object
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the tag of the other object is in the list of tags
        bool tagInList = tags.Contains(other.gameObject.tag);

        // Check if the tagListType is Blacklist and the tag is in the Blacklist
        if (tagListType == TagListType.Blacklist 
            && tagInList)
        {
            // Destroy if it's a Blacklist and the tag IS in the Blacklist
            Destroy(gameObject);
        }
        // Check if the tagListType is Whitelist and the tag is NOT in the Whitelist
        else if (tagListType == TagListType.Whitelist 
            && !tagInList)
        {
            // Destroy if it's a Whitelist and the tag is NOT in the Whitelist
            Destroy(gameObject);
        }
        else
        {
            // Use default collision code
        }
    }
}
