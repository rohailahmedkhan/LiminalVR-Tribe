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
        target = GameObject.Find("Player"); // getting current position of player
        level = new Level(target.GetComponent<Player>().GetCurrentSetName()); // Assigning Inherited methods of Level Class to Interface
        Debug.Log("Monster Loaded: " + level.SceneName);
    }

    void Update()
    {
        target = GameObject.Find("Player"); // getting current position of player     
        // Movement towards Player..
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, level.MonsterSpeed * Time.deltaTime);

        transform.LookAt(target.transform);
    }

    private void OnCollisionEnter(Collision collision) // Collision Event - will be updated once Monsters are developed
    {
        /*if (collision.gameObject.name == "Terrain" || collision.gameObject.name.Contains("Road") || 
            collision.gameObject.name.Contains("Plane"))
        {

        }
        else { Destroy(this.gameObject); }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
