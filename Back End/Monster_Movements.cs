using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Getting Current Position of Player
    GameObject target;

    // Movement speed for Monsters
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // finding and setting current position of the player
        target = GameObject.Find("Player");

        // calculating the movement required for monsters towards Player
        float step = speed * Time.deltaTime;

        // assigning the transofrmation
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }
}
