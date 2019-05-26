using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Movements : MonoBehaviour
{
    // Getting Current Position of Player
    GameObject target;

    // Movement speed for Monsters
    float speed = 1.5f;
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // checking current position of monster is out of plane or not..
        if (transform.position.y < 0) { Destroy(gameObject); }
        
        // finding and setting current position of the player
        target = GameObject.Find("Player");

        // calculating the movement required for monsters towards Player
        float step = speed * Time.deltaTime;

        // assigning the transofrmation
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }
}
