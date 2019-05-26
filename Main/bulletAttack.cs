using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletAttack : MonoBehaviour
{
    GameObject player;
    int power = 0;
    ILevel level;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        level = new Level(player.GetComponent<Player>().GetCurrentSetName());   
        power = level.GunPower;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.forward * Time.deltaTime * 25;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.StartsWith("CMonster"))
        {
            Debug.Log(other.gameObject.name);
            var monster = GameObject.Find(other.gameObject.name);
            monster.GetComponent<Monster>().CalculateDamage(power);
        }
        
    }
}
