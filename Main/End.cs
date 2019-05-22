using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    int set = 0;
    float angle = 0;
    Vector3 rotation = Vector3.up;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player") // Checking player as collision
        {
            GameObject plyr = GameObject.Find("Player"); // taking current position
            set++; // Changing set to next level..
            plyr.transform.position = transform.position; // Saving the current position of End object


            plyr.GetComponent<Player>().ChangeSet(set); // Calling Change set function of Player
            // Transformation according to sets
            if (set == 6)
                { transform.position = new Vector3(262.38f, transform.position.y,  19.77f); }
            if (set == 5)
                { transform.position = new Vector3(262.38f, transform.position.y, -34.77f); }
            if (set == 4)
                { transform.position = new Vector3(218.34f, transform.position.y, -34.77f); }
            if (set == 3)
                { transform.position = new Vector3(218.34f, transform.position.y, -62.77f); }
            if (set == 2)
                { transform.position = new Vector3(159.20f, transform.position.y, -62.77f); }
            if (set == 1)
                { transform.position = new Vector3(159.20f, transform.position.y, -26.77f); }

            Debug.Log("Collision Enter from Trigger" + (set)); // Checking purpose
            // plyr.transform.position = oldPosition;
            // plyr.transform.RotateAround(oldPosition, rotation, angle); //Rotation for the player 
            
        }
        
    }
}
