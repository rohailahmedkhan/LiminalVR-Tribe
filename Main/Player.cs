using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    ILevel level;
    GameObject script_monster;
    void Start()
    {
        level = new Level("Set_0"); // setting initial set on load

        // Creating Script for Monster Instantiate
        script_monster = new GameObject();
        script_monster.AddComponent<Monster_Instantiate>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, level.EndObject.transform.position,
            level.PlayerSpeed * Time.deltaTime); // Player movement towards end object

        CheckMonsters();
        Debug.Log(level.CloneMonsters);
    }

    public void ChangeSet(int set)
    {
        level = new Level("Set_" + set); // Changing required Logic as per set changes
        var NumberOfObjects = GameObject.FindGameObjectsWithTag("RandMonster");
        
        foreach (GameObject GO in NumberOfObjects) { Destroy(GO); }

        if (level.SceneName == "Set_7")
        {
            Application.Quit(); // Ending the game
        }
    }

    public string GetCurrentSetName() { return level.SceneName; } // Returning Active Set Name

    void CheckMonsters()
    {
        var NumberOfObjects = GameObject.FindGameObjectsWithTag("RandMonster");

        // Checking current number of monsters with max required number of monsters..
        if (NumberOfObjects.Length < level.CloneMonsters)
        {
            // Creating new monsters as required
            if (script_monster.GetComponent<Monster_Instantiate>().AddMonster(level.SceneName))
            {
                Debug.Log("Success while adding monster");
            }
            else { Debug.Log("Issue while adding monster"); }
            // getting current monsters count
            
        }
    }
}
