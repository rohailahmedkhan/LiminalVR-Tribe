using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    ILevel level;

    void Start()
    {
        level = new Level("Set_0"); // setting initial set on load
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, level.EndObject.transform.position,
            level.PlayerSpeed * Time.deltaTime); // Player movement towards end object
    }

    public void ChangeSet(int set)
    {
        level = new Level("Set_" + set); // Changing required Logic as per set changes
        if (level.SceneName == "Set_7")
        {
            Application.Quit(); // Ending the game
        }
    }

    public string GetCurrentSetName() { return level.SceneName; } // Returning Active Set Name


}
