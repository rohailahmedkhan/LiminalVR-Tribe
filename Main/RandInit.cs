using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandInit : MonoBehaviour
{
    ILevel level; // Creating object of Interface Class..
    GameObject player; // Getting Current player position..
    
    void Start()
    {
        level = new Level(SceneManager.GetActiveScene().name);
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // getting current count of monsters at frame
        var NumberOfObjects = GameObject.FindGameObjectsWithTag("RandMonster");

        // Checking current number of monsters with max required number of monsters..
        if (NumberOfObjects.Length < level.MaxMonsters)
        {
            // getting current monsters count
            level.CloneMonsters = NumberOfObjects.Length;
            // Creating new monsters as required
            RandomMonster();
        }
    }

    void RandomMonster()
    {
        // Specifing object to Init as Monster or anything... 
        GameObject monster = GameObject.Find("Monster");

        // Calling method to call create monsters
        CreateMonster(monster);
        // Increasing current monster count by one
        level.CloneMonsters++;
    }

    void CreateMonster(GameObject monster)
    {
        // Position Assignment
        float x, y, z;
        x = player.transform.position.x + 20.0f + Random.Range(-2f, 2f);
        y = player.transform.position.y + 1f;
        z = player.transform.position.z + Random.Range(-4f, 4f) * 0.9f;

        // Instantiate Object
        var RandObj = Instantiate(monster, new Vector3(x, y, z), Quaternion.identity);

        // Attach Tag
        RandObj.tag = "RandMonster";
        RandObj.GetComponent<Renderer>().enabled = true;
        RandObj.GetComponent<Rigidbody>().mass = level.MonsterMass;
        RandObj.isStatic = false;
        // Attach Script
        RandObj.AddComponent<Monster>();
        RandObj.name = "CMonster";
    }

    
}
