using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    ILevel level; // Creating object of Interface
    GameObject target; // Target for monsters which will be Player
    
    void Start()
    {
        level = new Level(SceneManager.GetActiveScene().name); // Assigning Inherited methods of Level Class to Interface
    }

    void Update()
    {
        target = GameObject.Find("Player"); // getting current position of player
        // Movement towards Player..
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, level.MonsterSpeed); 
    }

    private void OnCollisionEnter(Collision collision) // Collision Event - will be updated once Monsters are developed
    {
        /*if (collision.gameObject.name == "Terrain" || collision.gameObject.name.Contains("Road") || 
            collision.gameObject.name.Contains("Plane"))
        {

        }
        else { Destroy(this.gameObject); }*/
    }

}
