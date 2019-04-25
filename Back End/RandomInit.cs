using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInit : MonoBehaviour
{
    GameObject mypref;
    GameObject player;
    GameObject ground;
    int MaxMonster = 6;
    int clonecount = 0;

    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.Find("ground");
        RandomMonster();
    }

    // Update is called once per frame
    void Update()
    {
        var NumberOfObjects = GameObject.FindGameObjectsWithTag("RandMonster");

        if (NumberOfObjects.Length < MaxMonster)
        {
            clonecount = NumberOfObjects.Length;
            RandomMonster();
        }
    }

    void RandomMonster()
    {
        // Specifing object to Init as Monster or anything... 
        mypref = GameObject.Find("Cube");
        player = GameObject.Find("Player");
        for (int i = clonecount; clonecount < MaxMonster ; i++)
        {
            CreateMonster();
            clonecount++;
        }
    }

    void CreateMonster()
    {
        // Position Assignment
        float x, y, z;
        Debug.Log(player.transform.position);
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
