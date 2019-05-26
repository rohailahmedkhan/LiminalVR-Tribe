using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    // movement speed of Player
    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Movement of Player in each frame
        transform.position += Vector3.left * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // destroying the monsters on collison.. Not required just experiments..
        if(collision.gameObject.name != "ground")
        {
            Destroy(collision.gameObject);
        }
    }
}
