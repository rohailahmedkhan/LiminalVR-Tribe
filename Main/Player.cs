using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    ILevel level; // Creating object of Interface Class..

    void Start()
    {
        level = new Level(SceneManager.GetActiveScene().name); // Initialising with Level Class.. for specific levels..
    }

    // Update is called once per frame
    void Update()
    {
        // Moving towards the end object of Respected Level..
        transform.position = Vector3.MoveTowards(transform.position, level.EndObject.transform.position,
            level.PlayerSpeed );

        // Checking if Player reached to the position of End Object to Load Next Level or End the VR Experience..
        if (level.EndObject.transform.position.x - 1 < this.transform.position.x)
        {
            // level.EndObject = GameObject.Find("End_2");
            Application.Quit(); // Quiting the Application - will be changed once other Level's are developed..
        }
    }

    
}
