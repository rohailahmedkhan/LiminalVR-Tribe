using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInit : MonoBehaviour
{
    // Creating variables to track real time changes 
    GameObject mypref, player;
    // Max Monsters to appear and current monster count as cloning of the objects
    int MaxMonster = 6, clonecount = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Creating monsters at run time
        RandomMonster();
    }

    // Update is called once per frame
    void Update()
    {
        // getting current count of monsters at frame
        var NumberOfObjects = GameObject.FindGameObjectsWithTag("RandMonster");

        // Checking current number of monsters with max required number of monsters..
        if (NumberOfObjects.Length < MaxMonster)
        {
            // getting current monsters count
            clonecount = NumberOfObjects.Length;
            // Creating new monsters as required
            RandomMonster();
        }
    }
    // To Randomly generate monster
    void RandomMonster()
    {
        // Specifing object to Init as Monster or anything... 
        mypref = GameObject.Find("Cube");
        player = GameObject.Find("Player");

        // Calling method to call create monsters
        CreateMonster();
        // Increasing current monster count by one
        clonecount++;
    }

    // To Create Monster at runtime
    void CreateMonster()
    {
        // Position Assignment
        float x, y, z;
        x = player.transform.position.x - 15.0f - Random.Range(-1f, 1f) * 5;
        y = player.transform.position.y + 1;
        z = Random.Range(-1.5f, 1.5f) * 5;

        // Instantiate Object
        var RandObj = Instantiate(mypref, new Vector3(x, y, z), Quaternion.identity);

        // Attach Tag
        RandObj.tag = "RandMonster";

        // Attach Script
        RandObj.AddComponent<Monster_Movements>();
    }
}
